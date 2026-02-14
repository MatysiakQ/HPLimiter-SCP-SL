# HpLimiter

> 🇵🇱 [Polski](#polski) | 🇬🇧 [English](#english)

---

# Polski

![Version](https://img.shields.io/badge/wersja-1.0.0-blue)
![EXILED](https://img.shields.io/badge/EXILED-compatible-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

Lekki plugin do SCP: Secret Laboratory, który pozwala **ustawić HP i HumeShield dla każdego klasycznego SCP z poziomu configu** — bez modyfikacji kodu, bez rekompilacji.

---

## ✨ Funkcje
- Konfigurowalny HP dla każdego SCP osobno (173, 049, 096, 106, 939, 3114...)
- Konfigurowalny HumeShield dla każdego SCP osobno
- Wartość `0` = nie ruszamy, gra używa swoich domyślnych wartości
- **Automatycznie pomija graczy z CustomRole** (np. SCP-066, SCP-153) — nie nadpisuje ich HP
- Zero zależności poza EXILED

---

## Wymagania
- [EXILED](https://github.com/ExMod-Team/EXILED) (najnowsza wersja)
- [Exiled.CustomRoles](https://github.com/ExMod-Team/EXILED) (dołączone do EXILED)

---

## Instalacja
Wrzuć skompilowany plik `HpLimiter.dll` do folderu:
```
EXILED/Plugins/
```
Gotowe. Żadnych dodatkowych folderów ani plików.

---

## Konfiguracja
Po pierwszym uruchomieniu serwera config pojawi się automatycznie w:
```
EXILED/Configs/config_gameplay.yml
```

Przykładowy config:
```yaml
hplimiter:
  is_enabled: true
  debug: false
  scp_config:
    Scp173:
      health: 3000
      hume_shield: 0
    Scp049:
      health: 2500
      hume_shield: 0
    Scp0492:
      health: 400
      hume_shield: 0
    Scp096:
      health: 2200
      hume_shield: 0
    Scp106:
      health: 1200
      hume_shield: 0
    Scp939:
      health: 2300
      hume_shield: 0
    Scp079:
      health: 0
      hume_shield: 0
    Scp3114:
      health: 1200
      hume_shield: 0
```

### Zasady konfiguracji
| Wartość | Efekt |
|---|---|
| `health: 0` | HP nie jest zmieniane — gra używa domyślnej wartości |
| `health: 3000` | SCP startuje z dokładnie 3000 HP |
| `hume_shield: 0` | HumeShield nie jest zmieniany |
| `hume_shield: 500` | SCP startuje z dokładnie 500 HumeShield |

> **SCP-079** nie posiada HP ani HumeShield — zostaw oba jako `0`.

---

## Jak działa
1. Gracz dostaje rolę SCP i spawnuje się
2. Plugin sprawdza czy gracz **nie ma CustomRole** (066, 153 itp.) — jeśli ma, odpuszcza
3. Po **0.3s** (żeby gra zdążyła ustawić swoje domyślne wartości) plugin nadpisuje HP i HumeShield zgodnie z configiem
4. Gotowe — gracz gra z twoimi wartościami

---

## Autor
**Matysiak** — wersja 1.0.0

---
---

# English

![Version](https://img.shields.io/badge/version-1.0.0-blue)
![EXILED](https://img.shields.io/badge/EXILED-compatible-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

A lightweight plugin for SCP: Secret Laboratory that lets you **set HP and HumeShield for each classic SCP via config** — no code changes, no recompilation needed.

---

## ✨ Features
- Configurable HP for each SCP individually (173, 049, 096, 106, 939, 3114...)
- Configurable HumeShield for each SCP individually
- Value `0` = leave it alone, game uses its default values
- **Automatically skips CustomRole players** (e.g. SCP-066, SCP-153) — won't overwrite their HP
- Zero dependencies beyond EXILED

---

## Requirements
- [EXILED](https://github.com/ExMod-Team/EXILED) (latest version)
- [Exiled.CustomRoles](https://github.com/ExMod-Team/EXILED) (included with EXILED)

---

## Installation
Drop the compiled `HpLimiter.dll` into:
```
EXILED/Plugins/
```
That's it. No extra folders or files needed.

---

## Configuration
After the first server launch, the config will appear automatically in:
```
EXILED/Configs/config_gameplay.yml
```

Example config:
```yaml
hplimiter:
  is_enabled: true
  debug: false
  scp_config:
    Scp173:
      health: 3000
      hume_shield: 0
    Scp049:
      health: 2500
      hume_shield: 0
    Scp0492:
      health: 400
      hume_shield: 0
    Scp096:
      health: 2200
      hume_shield: 0
    Scp106:
      health: 1200
      hume_shield: 0
    Scp939:
      health: 2300
      hume_shield: 0
    Scp079:
      health: 0
      hume_shield: 0
    Scp3114:
      health: 1200
      hume_shield: 0
```

### Configuration rules
| Value | Effect |
|---|---|
| `health: 0` | HP is not changed — game uses its default value |
| `health: 3000` | SCP starts with exactly 3000 HP |
| `hume_shield: 0` | HumeShield is not changed |
| `hume_shield: 500` | SCP starts with exactly 500 HumeShield |

> **SCP-079** has no HP or HumeShield — leave both as `0`.

---

## How it works
1. Player receives an SCP role and spawns
2. Plugin checks if the player **does not have a CustomRole** (066, 153 etc.) — if they do, it skips them
3. After **0.3s** (to let the game set its own default values first) the plugin overwrites HP and HumeShield according to the config
4. Done — player plays with your values

---

## Author
**Matysiak** — version 1.0.0
