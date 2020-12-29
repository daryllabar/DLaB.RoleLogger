using DLaB.Xrm.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using DLaB.RoleLogger.Xrm.Entities;
using DLaB.RoleLogger.Xrm.Test;
using DLaB.RoleLogger.Xrm.Test.Builders;
using DLaB.Xrm;
using Microsoft.Xrm.Sdk.Messages;

namespace DLaB.RoleLogger.Xrm.Plugin.Tests
{
    [TestClass]
    public class PluginTests
    {
        #region OnAssign_Should_PostAssign

        [TestMethod]
        public void Plugin_OnAssign_Should_PostAssign()
        {
            new OnAssign_Should_PostAssign().Test();
        }

        // ReSharper disable once InconsistentNaming
        private class OnAssign_Should_PostAssign : TestMethodClassBase
        {
            private struct Ids
            {
                public static readonly Id<Post> Post = new Id<Post>("D94FF3E2-9E75-4EA1-A60E-DC31F12C56D3");
                public struct Roles
                {
                    public static readonly Id<Role> A = new Id<Role>("8A58EA48-4CAE-48F8-AF44-A9B809874689");
                    public static readonly Id<Role> B = new Id<Role>("DFC1511F-A0DC-4EB9-8DB7-D3143595192F");
                }
            }

            private List<Role> Roles { get; set; }

            protected override void InitializeTestData(IOrganizationService service)
            {
                if (TestBase.UseLocalCrmDatabase)
                {
                    Ids.Roles.A.Entity.Name = "Role A";
                    Ids.Roles.B.Entity.Name = "Role B";
                    new CrmEnvironmentBuilder().WithEntities<Ids.Roles>().Create(service);
                    Roles = EntityIdsByLogicalName[Ids.Roles.A].Select(e=> e.Entity.ToEntity<Role>()).ToList();
                }
                else
                {
                    var qe = QueryExpressionFactory.Create<Role>(r => new
                    {
                        r.Name, r.Id
                    }).Take(2);
                    Roles = service.GetEntities(qe);
                }
            }

            protected override void Test(IOrganizationService service)
            {
                service = new OrganizationServiceBuilder(service)
                          .WithIdsDefaultedForCreate(Ids.Post)
                          .Build();

                //
                // Arrange
                //
                var plugin = new Plugins.Plugin();
                var user = new EntityReference(SystemUser.EntityLogicalName, service.GetCurrentlyExecutingUserInfo().UserId);
                var request = new AssociateRequest
                {
                    Target = user,
                    Relationship = new Relationship("systemuserroles_association"),
                    RelatedEntities = new EntityReferenceCollection(Roles.Select(r => r.ToEntityReference()).ToList())
                };

                var context = new PluginExecutionContextBuilder()
                              .WithInitiatingUser(user.Id)
                              .WithFirstRegisteredEvent(plugin)
                              .WithInputRequest(request)
                              .Build();
                
                var serviceProvider = new ServiceProviderBuilder(service, context, Logger).Build();

                //
                // Act
                //
                plugin.Execute(serviceProvider);

                //
                // Assert
                //
                var post = service.GetEntity(Ids.Post);
                Assert.IsNotNull(post);
                Assert.IsTrue(post.Text.Contains("added the following roles to"));
                Assert.IsTrue(post.Text.Contains(Roles[0].Id.ToString()));
                Assert.IsTrue(post.Text.Contains(Roles[1].Id.ToString()));
            }
        }

        #endregion OnAssign_Should_PostAssign
    }
}
