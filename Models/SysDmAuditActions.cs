using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIs.Models
{
    [Table("sys_dm_audit_actions")]
    public partial class SysDmAuditActions
    {
        [Column("action_id")]
        [StringLength(4)]
        public string ActionId { get; set; }
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; }
        [Column("class_desc")]
        [StringLength(35)]
        public string ClassDesc { get; set; }
        [Column("covering_action_name")]
        [StringLength(128)]
        public string CoveringActionName { get; set; }
        [Column("parent_class_desc")]
        [StringLength(35)]
        public string ParentClassDesc { get; set; }
        [Column("covering_parent_action_name")]
        [StringLength(128)]
        public string CoveringParentActionName { get; set; }
        [Column("configuration_level")]
        [StringLength(128)]
        public string ConfigurationLevel { get; set; }
        [Column("containing_group_name")]
        [StringLength(128)]
        public string ContainingGroupName { get; set; }
        [Column("action_in_log")]
        public bool? ActionInLog { get; set; }
    }
}
