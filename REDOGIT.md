# REDOGIT — Orbit fork

This repository is an upstream-derived fork of Orbit Engine. REDOGIT applies here by preserving attribution and separating local work from upstream work.

## Boundary

- **Upstream engine:** remains identifiable as the Orbit Engine project this fork came from.
- **Local experiments:** must be added as explicit successors or deltas, not presented as if they were upstream history.
- **Orbit Lab research:** is a different project and does not belong in this repository merely because it shares the word `Orbit`.

## Verified predecessor baseline

The inherited .NET 6 MAUI engine has been reconstructed on current GitHub-hosted runners without reclassifying it as new local authorship.

The recovered baseline uses:

- .NET SDK `6.0.428` selected by `global.json`;
- current surviving MAUI 6 workload manifests (`6.0.553`) and MAUI Graphics `6.0.501`;
- Android API level 31;
- modern runner Java only for today's Android SDK manager, followed by JDK 11 for the inherited Xamarin/MAUI Android build.

Both platform workflows now pass restore, the full multi-target engine build, test build, test execution, and package creation:

- Windows workflow run `34719088760` — PASS.
- macOS workflow run `34719094126` — PASS.

These are predecessor-verification results. They do not change the fork's attribution boundary.

## Redo rule

1. Preserve upstream provenance.
2. Identify the behavior or limitation being changed.
3. Add the smallest local delta that demonstrates the change.
4. Test the delta independently where practical.
5. Keep local research terminology out unless the engine actually implements it.
6. Rebase or replace local experiments only with explicit lineage to the predecessor.

A fork is a relation, not a claim of authorship.
