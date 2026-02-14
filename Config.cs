using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using PlayerRoles;

namespace HpLimiter
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("HP i HumeShield dla poszczegolnych SCP. 0 = wartość domyślna gry.")]
        public Dictionary<RoleTypeId, ScpStatEntry> ScpConfig { get; set; } = new Dictionary<RoleTypeId, ScpStatEntry>
        {
            { RoleTypeId.Scp173,  new ScpStatEntry { Health = 3000f, HumeShield = 0f  } },
            { RoleTypeId.Scp049,  new ScpStatEntry { Health = 2500f, HumeShield = 0f  } },
            { RoleTypeId.Scp0492, new ScpStatEntry { Health = 400f,  HumeShield = 0f  } },
            { RoleTypeId.Scp096,  new ScpStatEntry { Health = 2200f, HumeShield = 0f  } },
            { RoleTypeId.Scp106,  new ScpStatEntry { Health = 1200f, HumeShield = 0f  } },
            { RoleTypeId.Scp939,  new ScpStatEntry { Health = 2300f, HumeShield = 0f  } },
            { RoleTypeId.Scp079,  new ScpStatEntry { Health = 0f,    HumeShield = 0f  } },
            { RoleTypeId.Scp3114, new ScpStatEntry { Health = 1200f, HumeShield = 0f  } },
        };
    }

    public class ScpStatEntry
    {
        [Description("HP dla tego SCP. 0 = domyślna wartość gry.")]
        public float Health { get; set; } = 0f;

        [Description("HumeShield dla tego SCP. 0 = domyślna wartość gry.")]
        public float HumeShield { get; set; } = 0f;
    }
}
