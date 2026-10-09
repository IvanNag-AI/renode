# Резерв исходников эмуляции EMVERIS

UTC: 2026-10-09T15:29:50.953545+00:00

Это резерв исходников и происхождения. Готовность к интеграции, успешная сборка и исполнение firmware здесь не проверялись.

## Состав и проверка

Сохранено 32 исходных репозиториев: 10 отдельных форков и 22 историй в добавочных archive-sources refs нашего форка Renode. Default branch исходного Renode сохранена. Полные доступные heads/tags записаны с SHA; pinned commits закреплены отдельными refs.

После временного GitHub secondary rate limit на создание объектов остальные исходные истории опубликованы через обычный Git push в отдельные namespaces. История коммитов, авторство и tag objects не переписаны. Для annotated tags используется refs/tags/archive-sources. Обычные upstream refs не перезаписывались.

[Манифест](manifest.json), [карта MCU](mcu-map.json), [оригинальные артефакты и SHA256](artifacts.json), [внешние test assets](external-test-assets.json), [PackageReference](external-packages.json).

## Восстановление

Python 3 и Git. Скрипт обращается только к GitHub URL IvanNag-AI из манифеста, получает точные pinned refs, проверяет HEAD и git fsck каждого восстановленного репозитория. Каталог назначения должен отсутствовать.

```powershell
python restore.py "D:\path\renode-restored" --snapshot v1.17.0
python restore.py "D:\path\renode-build-restored" --snapshot f1dd1b4af
python restore.py "D:\path\renode-current-restored" --snapshot current
```

Renode release tag: `ab721d88e135a1bcb8ed2ecc5a38f51cbe61fdd2`. Packaged build identity: `1.17.0+20260906gitf1dd1b4af`, source commit `f1dd1b4af7838b45a925c17603cdfed0a583844a`. Это разные корневые ревизии; infrastructure pin 1.17.0: `066a7f13c052215632d469c995c89aea37c573b1`.

## Репозитории

| Upstream | Наш резерв | default / SHA | Тип / лицензия |
|---|---|---|---|
| [renode/renode](https://github.com/renode/renode) | [архив](https://github.com/IvanNag-AI/renode) | master / `150e30d3fee51a1fe1f64188173c69fe6cc5feb5` | fork / MIT framework; dependencies have separate licenses |
| [renode/renode-infrastructure](https://github.com/renode/renode-infrastructure) | [архив](https://github.com/IvanNag-AI/renode-infrastructure) | master / `515cc63eea5c6bbef943e797483f073fbdffdf95` | fork / MIT source notices and licenses/MIT.txt; consult per-file notices |
| [antmicro/tlib](https://github.com/antmicro/tlib) | [архив](https://github.com/IvanNag-AI/tlib) | master / `8620bc4a9c32814218f338f2f52163e4aaf8bfca` | fork / LGPL-2.1 libqemu-derived code unless otherwise stated; additional per-file notices |
| [antmicro/berkeley-softfloat-3](https://github.com/antmicro/berkeley-softfloat-3) | [архив](https://github.com/IvanNag-AI/berkeley-softfloat-3) | renode / `62f740d30f5f7962f7eefa6b32662a5faf2d8286` | fork / NOASSERTION |
| [antmicro/termsharp](https://github.com/antmicro/TermSharp) | [архив](https://github.com/IvanNag-AI/TermSharp) | master / `c13c96b95e92c1a8e29705f0884f690ea2f1a876` | fork / Apache-2.0 |
| [antmicro/xwt](https://github.com/antmicro/xwt) | [архив](https://github.com/IvanNag-AI/xwt) | master / `edb7793688c83448b1eb5336ab2fc9e98905eaa3` | fork / MIT |
| [antmicro/FdtSharp](https://github.com/antmicro/FdtSharp) | [архив](https://github.com/IvanNag-AI/FdtSharp) | master / `fb43c1507c2c7680d386fcef2dcb75bbe1fae273` | fork / MIT |
| [antmicro/Packet.Net](https://github.com/antmicro/Packet.Net) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--Packet.Net/heads/master) | master / `20e0f2fe40743fed4e6a81bb8fe9523c257f168b` | original-history-in-additional-namespaced-refs / LGPL-3.0 |
| [antmicro/AntShell](https://github.com/antmicro/AntShell) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--AntShell/heads/master) | master / `ca49bd325b6943802578d70ae575baddc7005a49` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [antmicro/elfsharp](https://github.com/antmicro/elfsharp) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--elfsharp/heads/renode_base) | renode_base / `bf797c5bbec983578ded3081a8e17d1c646e7c32` | original-history-in-additional-namespaced-refs / NOASSERTION |
| [antmicro/options-parser](https://github.com/antmicro/options-parser) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--options-parser/heads/master) | master / `34bc258cc4f6585af8c0bea5a77f0c2a9e43d481` | original-history-in-additional-namespaced-refs / MIT |
| [antmicro/CxxDemangler](https://github.com/antmicro/CxxDemangler) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--CxxDemangler/heads/master) | master / `71eb9736623081a09712a8cb08bcd322ce17c7b5` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [antmicro/InpliTftpServer](https://github.com/antmicro/InpliTftpServer) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--InpliTftpServer/heads/master) | master / `2a4877dce99fd7a30b85b5bf217c631538cd7086` | original-history-in-additional-namespaced-refs / BSD-3-Clause |
| [antmicro/BigGustave](https://github.com/antmicro/BigGustave) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--BigGustave/heads/master) | master / `6858c7e4e529e6bc6543fbaaea0f3523a2663a55` | original-history-in-additional-namespaced-refs / Unlicense |
| [antmicro/Migrant](https://github.com/antmicro/Migrant) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--Migrant/heads/master) | master / `9e135403b5e1612d9c6bed7d3498bf39ada0a95c` | original-history-in-additional-namespaced-refs / MIT |
| [antmicro/bc-csharp](https://github.com/antmicro/bc-csharp) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--bc-csharp/heads/renode_main) | renode_main / `e4dd148f9dcd179839ce8a24327186dbb1eb8353` | original-history-in-additional-namespaced-refs / MIT |
| [antmicro/dts2repl](https://github.com/antmicro/dts2repl) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--dts2repl/heads/main) | main / `e285e334c09e404eabd6e4110c86352832647c64` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [antmicro/renode-models-analyzer](https://github.com/antmicro/renode-models-analyzer) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--renode-models-analyzer/heads/main) | main / `f6ec17b71742ca48fe8d6e3fc60bda42c9890ae4` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [antmicro/renode-ui](https://github.com/antmicro/renode-ui) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--renode-ui/heads/main) | main / `99ad964656b566a3c8b07f3560af94877056833d` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [antmicro/DNNE](https://github.com/antmicro/DNNE) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/antmicro--DNNE/heads/master) | master / `45f1f180c2f5ef9314dfdeebf4192ce081a54fcf` | original-history-in-additional-namespaced-refs / MIT |
| [matgla/Renode_RP2040](https://github.com/matgla/Renode_RP2040) | [архив](https://github.com/IvanNag-AI/Renode_RP2040) | main / `5aca847c9f57ed96603e55d28e8ceeefa09e55f6` | fork / MIT model code; bundled RP2040 ROM has separate Raspberry Pi/Mark Owen terms including GPLv2 alternative; integration not cleared |
| [matgla/Renode_RP2040_PioSim](https://github.com/matgla/Renode_RP2040_PioSim) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/matgla--Renode_RP2040_PioSim/heads/main) | main / `4001615fcf1143573cf1cec195b9f5798573249b` | original-history-in-additional-namespaced-refs / MIT |
| [wokwi/rp2040js](https://github.com/wokwi/rp2040js) | [архив](https://github.com/IvanNag-AI/rp2040js) | main / `a304c7486f329dae64be5f65baf28795d62ceb95` | fork / MIT model code; bundled RP2040 ROM has separate Raspberry Pi/Mark Owen terms including GPLv2 alternative; integration not cleared |
| [buserror/simavr](https://github.com/buserror/simavr) | [архив](https://github.com/IvanNag-AI/simavr) | master / `d6aed536755bd0ff72b9d2bf02e4a476af64ce82` | fork / GPL-3.0 |
| [espressif/qemu](https://github.com/espressif/qemu) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--qemu/heads/esp-develop) | esp-develop / `febae182e132e4055529be423a818225ebddaa3a` | original-history-in-additional-namespaced-refs / GPL-2.0 QEMU as a whole; mixed compatible file licenses; firmware separately licensed |
| [OpenE2K/qemu-e2k-tests](https://github.com/OpenE2K/qemu-e2k-tests) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/OpenE2K--qemu-e2k-tests/heads/master) | master / `fd25341bd3d778400b329f86fc1df90d2af6b084` | original-history-in-additional-namespaced-refs / GPL-3.0 |
| [OpenE2K/qemu-e2k](https://github.com/OpenE2K/qemu-e2k) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/OpenE2K--qemu-e2k/heads/e2k) | e2k / `ebc4bbdbe5d74bbf5a59784f697a6df64a9aa299` | original-history-in-additional-namespaced-refs / GPL-2.0 QEMU as a whole; mixed compatible file licenses; firmware separately licensed |
| [espressif/esp-rom-elfs](https://github.com/espressif/esp-rom-elfs) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--esp-rom-elfs/heads/master) | master / `37b4a88f50e151f1b9e0d6c5409471035ea0ea37` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [NathanY3G/rp2040-pio-emulator](https://github.com/NathanY3G/rp2040-pio-emulator) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/NathanY3G--rp2040-pio-emulator/heads/main) | main / `abd90e0bf91ff09b3824fd13e8715ff886fda19d` | original-history-in-additional-namespaced-refs / Apache-2.0 |
| [raspberrypi/pico-bootrom-rp2350](https://github.com/raspberrypi/pico-bootrom-rp2350) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/raspberrypi--pico-bootrom-rp2350/heads/master) | master / `c6cdb1711f32c3e34faaebd58618a6d096dbd52e` | original-history-in-additional-namespaced-refs / BSD-3-Clause source notices; LICENSE.TXT separately excludes historical muFP paths |
| [raspberrypi/pico-bootrom](https://github.com/raspberrypi/pico-bootrom-rp2040) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/raspberrypi--pico-bootrom/heads/master) | master / `ef22cd8ede5bc007f81d7f2416b48db90f313434` | original-history-in-additional-namespaced-refs / BSD-3-Clause except muFP files: device-only Raspberry Pi terms plus author-stated GPLv2 alternative; no blanket BSD/MIT claim |
| [GhostRoboticsLab/rp2350js_emulator](https://github.com/GhostRoboticsLab/rp2350js_emulator) | [архив](https://github.com/IvanNag-AI/renode/tree/archive-sources/GhostRoboticsLab--rp2350js_emulator/heads/main) | main / `fee5726521c989cd1dd2c996a65acbebc9d2ce16` | original-history-in-additional-namespaced-refs / MIT model code; bundled RP2040 ROM has separate Raspberry Pi/Mark Owen terms including GPLv2 alternative; integration not cleared |

## Карта MCU

Каждая строка имеет точные пути исходников/тестов и commit в mcu-map.json. Наличие файла или заявления автора не означает полный SoC, физическую точность или прохождение прошивки.

| Чип / семейство | Источник / тип | Пробелы |
|---|---|---|
| STM32F0 / F042 / F072 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32F1 / F103 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32F4 / F412 / F429 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32F7 / F746 / F777 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32G0 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32H7 / H743 / H747 / H753 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32L0 / L071 / L072 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32L1 / L151 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32L5 / L552 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32W108 / WBA52 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform descriptions / test definitions | Coverage is limited to listed descriptions and their referenced models; tests were retained but not run. |
| STM32F303 | [renode/renode-infrastructure](https://github.com/IvanNag-AI/renode-infrastructure); Renode peripheral source; not a dedicated F303 SoC | No dedicated F303 platform in the retained Renode root snapshots. EMVERIS custom F303 adapters are outside this archive. |
| STM32F411 | [renode/renode](https://github.com/IvanNag-AI/renode); Generic STM32F4 description; not dedicated F411 | No dedicated F411 description found in retained root snapshots. Generic F4 is not proof of F411 fidelity. |
| STM32G4 | not-found; No dedicated model found in reviewed Renode snapshots | Search result is scoped, not a claim that no model exists anywhere. |
| STM32U family | not-found; No dedicated model found in reviewed Renode snapshots | Search result is scoped, not a claim that no model exists anywhere. |
| STM32H5 | not-found; No dedicated model found in reviewed Renode snapshots | Search result is scoped, not a claim that no model exists anywhere. |
| ESP32 | [espressif/qemu](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--qemu/heads/esp-develop); Official QEMU SoC machine source / Xtensa LX6 | Model and peripherals differ by target. Wireless/electrical fidelity and firmware execution not checked here. |
| ESP32-S3 | [espressif/qemu](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--qemu/heads/esp-develop); Official QEMU SoC machine source / Xtensa LX7 | Model and peripherals differ by target. Wireless/electrical fidelity and firmware execution not checked here. |
| ESP32-C3 | [espressif/qemu](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--qemu/heads/esp-develop); Official QEMU SoC machine source / RISC-V | Model and peripherals differ by target. Wireless/electrical fidelity and firmware execution not checked here. |
| ESP32-C6 | [espressif/qemu](https://github.com/IvanNag-AI/renode/tree/archive-sources/espressif--qemu/heads/esp-develop); Official QEMU SoC machine source / RISC-V | Model and peripherals differ by target. Wireless/electrical fidelity and firmware execution not checked here. |
| ESP32 / S2 / S3 partial peripherals | [renode/renode-infrastructure](https://github.com/IvanNag-AI/renode-infrastructure); Partial Renode peripheral sources | Enum values and shared controllers do not establish a complete Xtensa CPU/SoC or platform. |
| ESP32-C3 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-C5 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-C6 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-H2 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-P4 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-S3 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-S31 | found-not-saved; Vendor binary distribution/docs/test apps; emulator core source unavailable | Only distribution scaffolding is public here; core source is absent. Targets are vendor claims, not archived open SoC implementations. |
| ESP32-S2 complete SoC | not-found; No complete machine confirmed in selected QEMU/Renode sources | Renode has partial generation/peripheral definitions; this is not complete S2 support. |
| RP2040 | [matgla/Renode_RP2040](https://github.com/IvanNag-AI/Renode_RP2040); Third-party Renode RP2040 models | Upstream marks WIP/frozen. USB/PWM/RTC missing, PIO synchronisation and other peripherals partial. No integration run. |
| RP2040 PIO | [matgla/Renode_RP2040_PioSim](https://github.com/IvanNag-AI/renode/tree/archive-sources/matgla--Renode_RP2040_PioSim/heads/main); Native PIO co-simulation source | PIO CPU scheduling/ABI/build requirements need separate validation. |
| RP2040 | [wokwi/rp2040js](https://github.com/IvanNag-AI/rp2040js); TypeScript MCU emulator | Separate emulator; completeness and firmware acceptance not checked. |
| RP2350 / Hazard3 RISC-V | [GhostRoboticsLab/rp2350js_emulator](https://github.com/IvanNag-AI/renode/tree/archive-sources/GhostRoboticsLab--rp2350js_emulator/heads/main); Third-party RP2040JS fork with RP2350 core/SoC/test source | Author firmware/test claims not rerun. Cortex-M33 mode and physical fidelity not established. Inherited RP2040 ROM terms are separate from MIT model code. |
| RP2040 / RP2350 / RP2354 Rust candidate | found-not-saved; Independent Rust emulator candidate | Not archived: bundled patched third-party firmware/game-derived fixtures need a separate provenance/completeness review; author cycle-accuracy claims not tested. |
| RP2350 / Hazard3 RISC-V mode | found-not-saved; Independent C# MCU emulator | Not republished: embedded extracted datasheet/ROM provenance requires redistribution review. Early model: second core and Cortex-M33 unavailable; most peripherals partial/stub. |
| RP2040 / RP2350 PIO only | [NathanY3G/rp2040-pio-emulator](https://github.com/IvanNag-AI/renode/tree/archive-sources/NathanY3G--rp2040-pio-emulator/heads/main); PIO instruction emulator | PIO only; not full MCU firmware execution. |
| Nordic nRF52840 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| NXP i.MX RT1064 / RT500 / RT798S | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| Microchip ATSAMD21J17D / ATSAMD51G19A | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| TI MSP430F2619 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| TI CC2538 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| SiFive FE310 / FU540 / FU740 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| LiteX / VexRiscv / Ibex / PicoRV32 | [renode/renode](https://github.com/IvanNag-AI/renode); Renode platform + retained test/script sources | Coverage varies by platform; external test firmware may be unavailable; no tests executed here. |
| AVR / ATmega | [buserror/simavr](https://github.com/IvanNag-AI/simavr); Independent AVR emulator | Not a Renode backend; supported MCUs and peripheral fidelity need separate audit. |
| Elbrus E2K | [OpenE2K/qemu-e2k](https://github.com/IvanNag-AI/renode/tree/archive-sources/OpenE2K--qemu-e2k/heads/e2k); QEMU Linux user-mode ISA/syscall translator | User-mode support is not a motherboard/MCU/system peripheral model. |
| Elbrus E2K tests | [OpenE2K/qemu-e2k-tests](https://github.com/IvanNag-AI/renode/tree/archive-sources/OpenE2K--qemu-e2k-tests/heads/master); Author test source suite | Tests preserved, not compiled or run. |
| MIK32 Amur / K1948VK018 | not-found; No substantive open SoC execution model confirmed | Manufacturer/author GitHub and targeted code/repository searches did not establish a usable model. Generic ISA support is insufficient. |
| Milandr MDR / K1986 | not-found; No substantive open SoC execution model confirmed | Manufacturer/author GitHub and targeted code/repository searches did not establish a usable model. Generic ISA support is insufficient. |
| NIIET K1921 | not-found; No substantive open SoC execution model confirmed | Manufacturer/author GitHub and targeted code/repository searches did not establish a usable model. Generic ISA support is insufficient. |
| ELVIS processors | not-found; No substantive open SoC execution model confirmed | Manufacturer/author GitHub and targeted code/repository searches did not establish a usable model. Generic ISA support is insufficient. |
| Baikal processors | not-found; No substantive open SoC execution model confirmed | Manufacturer/author GitHub and targeted code/repository searches did not establish a usable model. Generic ISA support is insufficient. |
| MIK32 browser HAL simulator | found-not-saved; C/HAL text-to-JavaScript interpreter | Not genuine ELF/ISA MCU emulation; mixed embedded materials and no root license confirmed. |

## Что ещё требуется для независимого восстановления

Исходная цепочка и её pins сохранены; полный offline rebuild не заявляется. Не сохранены все NuGet/npm/Python/Cargo packages, точные compiler/SDK/system package окружения и внешние firmware/test assets. Для будущих QEMU/других backend исходники не означают полный recursive build environment. Upstream submodule URLs в оригинальных файлах оставлены нетронутыми; следует использовать restore.py, обычный git submodule update будет обращаться к upstream.

Чистое восстановление и runtime-проверки описаны в verification.json. Исходные тесты сохранены; в этой задаче MCU/firmware acceptance не запускались. Наличие Git LFS указателей проверяется по всем reachable малым blobs; результат по каждому репозиторию в manifest.json.

## Лицензии и происхождение

Renode framework — MIT; инфраструктура содержит MIT notices; tlib — LGPL-2.1 с отдельными file notices. QEMU — GPL-2.0 как целое, совместимые лицензии по файлам и отдельно лицензируемые firmware. AVR simavr — GPL-3.0; E2K tests — GPL-3.0. Лицензии библиотек не заменяются лицензией Renode. LICENSE/COPYING/NOTICE и метаданные остаются в исходных историях и оригинальных release archives. Это проверка наличия первичных условий, не юридическое заключение.

[Espressif ROM ELF terms](https://github.com/espressif/esp-rom-elfs/blob/master/README.md) разрешают объектную форму ROM ELF по Apache-2.0; ROM source не открыт. [QEMU LICENSE](https://github.com/espressif/qemu/blob/esp-develop/LICENSE) отдельно оговаривает firmware. [Raspberry Pi RP2350 boot ROM](https://github.com/raspberrypi/pico-bootrom-rp2350) содержит собственные условия. Закрытые SDK и пользовательские firmware в архив не добавлялись.

Российские MIK32/MDR/K1921/ELVIS/Baikal: содержательная открытая SoC-модель не подтверждена в выполненном поиске. Это ограниченный результат поиска. Найденный MIK32 HAL→JS simulator исключён; E2K сохранён отдельно как user-mode translator.

## Границы публикации

Архив содержит открытые upstream sources и служебную карту. Основной checkout, worktrees, GUI, физические порты и прошивка платы не изменялись. Cloud CI не включался.

## Проверенные различия источников и дополнительные зависимости

Тег v1.17.0 ссылается на infrastructure `066a7f13c052215632d469c995c89aea37c573b1`; commit packaged build f1dd1b4af — на `cd4b002aac2398994c4a61a34a8b31b5700facf2`. Проверенные файлы официального source archive совпали со второй цепочкой. [Сравнение файлов и SHA256](source-provenance.json) не является доказательством происхождения каждого compiled binary. Обе цепочки сохранены; [проверка build-цепочки](build-chain-verification.json).

[Будущие submodule dependencies](future-dependencies.json) перечислены с URL и pins; их полная рекурсивная сборочная среда не архивировалась. [PackageReference](external-packages.json) собраны по точным ревизиям каждой центральной цепочки, а не по default branch библиотек.

Для восстановления всех исходных heads/tags отдельного репозитория: `python restore_repository.py owner/repository D:/path/new-directory`. Скрипт возвращает исходные имена refs из манифеста, проверяет SHA и fsck. Проверен на полном наборе refs RP2040 PioSim.

Не сохранены в облаке: espressif/esp-emulator — исходники execution core отсутствуют; lukaspirkl/Lemur — до отдельной проверки условий встроенных извлечённых datasheet/ROM материалов. Локальные исследовательские копии не объявляются опубликованным резервом.

Создание optional private index было отклонено GitHub secondary rate limit. Общедоступный каталог содержит только сведения об открытых upstream и размещён в отдельной ветке archive-index нашего форка; частные исходники EMVERIS сюда не попали.

## Отдельные условия RP2040 ROM

MIT модели не перелицензирует включённый ROM. Raspberry Pi LICENSE.TXT исключает mufplib.S и mufplib-double.S: их заголовки содержат device-only вариант и прямо указывают GPLv2-альтернативу автора. [Первичные заголовки](https://github.com/raspberrypi/pico-bootrom-rp2040/blob/master/bootrom/mufplib.S), [автор Qfplib и GPLv2](https://www.quinapalus.com/qfplib.html). Исходные условия сохранены без изменения; отдельная GPL-альтернатива не превращает весь архив в MIT/BSD. Применимость к будущей поставке/исполнению требует отдельной проверки, которая не выполнена этой задачей сохранения.

Кандидат [picoem](https://github.com/0x4D44/picoem) найден, но не сохранён: в его NOTICE перечислены patched сторонние firmware и game-derived fixtures; цепочка их происхождения/исходников требует отдельного аудита. Заявления о cycle accuracy здесь не подтверждались.

## Итог объёма

32 исходных репозитория: 10 отдельных форков, 22 истории в дополнительных refs; 1101 исходная ветка/тег и 30 pinned refs. Три оригинальных release assets: 499 613 215 байт. Сумма размеров файлов выбранных локальных bare-репозиториев: 1 885 156 106 байт; это не размер физического/billed хранения GitHub, где объекты разделяются. [Машиночитаемые итоги](summary.json).

[Наш release с артефактами](https://github.com/IvanNag-AI/renode/releases/tag/emveris-backup-renode-1.17.0). Проверка каждого remote SHA, CI и повторное скачивание/запуск bundled Windows runtime с --version: [verification.json](verification.json).
