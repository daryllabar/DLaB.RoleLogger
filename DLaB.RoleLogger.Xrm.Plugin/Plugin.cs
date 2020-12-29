using Microsoft.Xrm.Sdk;
using Source.DLaB.Xrm.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using DLaB.RoleLogger.Xrm.Entities;
using DLaB.RoleLogger.Xrm.Plugin;
using Microsoft.Xrm.Sdk.Messages;
using Source.DLaB.Xrm;

namespace DLaB.RoleLogger.Xrm.Plugins
{

    public class Plugin : PluginBase, IPlugin
    {
        #region Constructors

        public Plugin(string unsecureConfig = null, string secureConfig = null) : base(unsecureConfig, secureConfig) { }

        #endregion Constructors

        protected override IEnumerable<RegisteredEvent> CreateEvents()
        {
            return new RegisteredEventBuilder(PipelineStage.PreOperation, MessageType.Associate, MessageType.Disassociate).Build();
        }

        protected override void ExecuteInternal(ExtendedPluginContext context)
        {
            var request = new AssociateRequest
            {
                Parameters = context.InputParameters
            };

            if (request.Relationship.SchemaName != "systemuserroles_association")
            {
                context.Trace("Request was not for SystemUser <-> Roles.  Exiting...");
                return;
            }

            var user = context.SystemOrganizationService.GetEntity<SystemUser>(context.InitiatingUserId, u => new {u.FullName, u.DomainName });
            var target = context.SystemOrganizationService.GetEntity<SystemUser>(request.Target.Id, u => new {u.FullName, u.DomainName});
            var roleIds = request.RelatedEntities
                               .Where(e => e.LogicalName == Role.EntityLogicalName)
                               .Select(e => e.Id).ToArray();
            var roleNames = context.SystemOrganizationService.GetEntitiesById<Role>(r => new {r.Name}, roleIds)
                                   .Select(r => $"{r.Name} ({r.Id})");

            var preSpacing = Environment.NewLine + "- ";
            var action = context.GetMessageType() == MessageType.Associate
                ? "added the following roles to"
                : "removed the following roles from";
            var text = $"User {user.FullName} ({user.DomainName}) has {action} user {target.FullName} {target.DomainName}: ";
            text += preSpacing + string.Join(preSpacing, roleNames);
            context.SystemOrganizationService.Create(new Post
            {
                RegardingObjectId = request.Target,
                Source = Post_Source.AutoPost,
                Text = text
            });

            context.Trace("Processing " + context.MessageName);
            context.TraceContext();
        }
    }

}
