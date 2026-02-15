using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System;

namespace HpLimiter
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        public override string Name => "HpLimiter";
        public override string Prefix => "hplimiter";
        public override string Author => "Matysiak";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.Spawned += OnSpawned;
            Log.Info("HpLimiter: Plugin zaladowany!");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnSpawned;
            Instance = null;
            base.OnDisabled();
        }

        private void OnSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player == null) return;

            // Tylko klasyczne SCPy - pomijamy graczy z CustomRole (066, 153 itd.)
            if (ev.Player.Role.Team != Team.SCPs) return;
            if (CustomRole.Registered != null && CustomRole.Registered.Count > 0)
            {
                foreach (var cr in CustomRole.Registered)
                {
                    if (cr.Check(ev.Player)) return;
                }
            }

            RoleTypeId role = ev.Player.Role.Type;
            if (!Config.ScpConfig.TryGetValue(role, out ScpStatEntry entry)) return;

            if (entry.Health > 0f)
            {
                ev.Player.MaxHealth = entry.Health;
                ev.Player.Health = entry.Health;
            }

            if (entry.HumeShield > 0f)
            {
                ev.Player.HumeShield = entry.HumeShield;
                ev.Player.MaxHumeShield = entry.HumeShield;
            }

            Log.Debug($"[HpLimiter] {ev.Player.Nickname} ({role}) -> HP: {entry.Health}, HS: {entry.HumeShield}");
        }
    }
}