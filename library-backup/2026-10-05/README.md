# Orbit Library — exact retained packages

These are backups of the user's Orbit Library from ChatGPT Library, uploaded at
the user's request on 2026-10-05. The native Library entry is `/Orbit Lab/CURRENT.md`.
Start there when working in the Library; do not assume GitHub is the original source.

## Restore

From this directory, run `python3 restore.py`. It verifies each part and complete
archive, then writes the original ZIPs under `restored/`. The September 13 ZIP is
stored in eight binary parts because of the connector request-size limit. These
parts reconstruct the original archive byte for byte. The September 30 package is
stored as one ordinary ZIP. No source bytes or expected digests were changed.

## Retained sources

- `Orbit_Library_Current_2026-09-13.zip`: full Library snapshot, including Current,
  History, Support, and nested predecessor/runnable packages; source Library ID
  `libfile_856029793530819190fee4a83b533cfd`.
- `Orbit_Lab_Reflow_1_0_STATIC_SEAL_SUCCESSOR_2026-09-30.zip`: later retained sealed
  successor; source Library ID `libfile_be7079897da48191836b36fd644feafa`.
- `MANIFEST.json`: archive and part SHA-256 values, sizes, and source identities.
- `ORBIT_LIBRARY_SCAN.json`: bounded direct Library-package scan, including nested
  archives. 33 distinct archives and 8,606 file members were scanned.

The exact engine SHA-256 is
`2910df6adb525143423fb23676e5aaf376669cd7686401b42f63d64863fe1f18`.
It is retained in these Library packages. This source identity is resolved.

The separate faithful custody source export remains missing:
`c390a188b2d3e167e18dca776cdb0945f3e534c0e45c7a5066b1a9aebe31ad60`,
Orbit occurrence `occurrence-710993e5d9`, content identity `contentidentity-4ec137ac01`.
Its original export path is `/mnt/data/final_loop_run/exports/faithful.tsv`.
Package backup does not discharge that missing-input obligation. The Orbit custody
bundle remains withheld, with no fresh seven-check PASS claim or authority promotion.

The Orbit Lab Cycle reminder was disabled at the user's request. Backup is custody,
not replacement of native source authority or proof of runtime integration.
