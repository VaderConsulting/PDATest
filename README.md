# PDATest

This is a Visual Studio 2008 VB.NET Windows Mobile 6 Professional (Pocket PC) WinForms app. On load it fills a Bluetooth RFCOMM `PORTEMUPortParams` structure (channel, MTU, auth/encrypt flags) using Microsoft.WindowsMobile.Telephony. It is my working copy from Historical Dev, an early PDA Bluetooth experiment.

**Source last updated:** 2008-06-21  
**Language:** VB.NET  
**Target:** .NET CF 2.0 / Windows Mobile 6 Professional  
**Output:** Pocket PC WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `PDATest` | VB.NET | WM6 WinForms | Form1 Bluetooth RFCOMM port params on load |

## How to open

Open `PDATest.sln` in Visual Studio 2008 with Windows Mobile 6 Professional SDK.

## Requirements

- Visual Studio 2008, .NET Framework 2.0

## Attribution and provenance

From Dave Robinson's Historical Dev archive (OneDrive folder `PDATest`). Assembly copyright 2008.

## License

MIT License. Copyright (c) 2026 Vader Consulting.
