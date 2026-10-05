#!/usr/bin/env python3
"""Restore and verify the exact Library ZIPs. Python standard library only."""
from pathlib import Path
import hashlib
import json

root = Path(__file__).resolve().parent
manifest = json.loads((root / 'MANIFEST.json').read_text())
for archive in manifest['archives']:
    if archive['parts']:
        chunks = []
        for part in archive['parts']:
            data = (root / 'archives' / part['name']).read_bytes()
            if len(data) != part['bytes'] or hashlib.sha256(data).hexdigest() != part['sha256']:
                raise SystemExit('Part verification failed: ' + part['name'])
            chunks.append(data)
        data = b''.join(chunks)
    else:
        data = (root / 'archives' / archive['name']).read_bytes()
    if len(data) != archive['bytes'] or hashlib.sha256(data).hexdigest() != archive['sha256']:
        raise SystemExit('Archive verification failed: ' + archive['name'])
    output = root / 'restored' / archive['name']
    output.parent.mkdir(exist_ok=True)
    if output.exists() and output.read_bytes() != data:
        raise SystemExit('Refusing to overwrite different bytes: ' + str(output))
    output.write_bytes(data)
    print('VERIFIED', archive['sha256'], output.name)
