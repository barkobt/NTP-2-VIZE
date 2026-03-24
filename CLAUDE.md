# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

Educational Windows Forms (.NET Framework 4.7.2) repository with 4 progressively complex C# applications, used to teach OOP and event-driven programming. All comments and UI text are in Turkish.

## Build & Run

Open in Visual Studio 2022+:
- Master solution: `NTP-2-VIZE.slnx`
- Each project has its own `.slnx` file for independent editing
- Build: `Ctrl+Shift+B`, Run: `F5`

No external NuGet packages — all dependencies come from the .NET Framework 4.7.2 GAC.

## Project Architecture

All projects follow the standard WinForms `partial class` pattern:
- `Form1.cs` — event handlers and business logic
- `Form1.Designer.cs` — auto-generated control definitions (do not edit manually)
- `Program.cs` — entry point (`Application.Run(new Form1())`)

### WindowsFormsApp1 — Loto (Lottery)
Two-form application: `Form1` generates lottery tickets and draws; `Form2` loads saved files and checks matches. Uses `System.IO` (`StreamWriter`, `File.ReadAllLines`) for persisting draw results and column data to `.txt` files. `Form2.ListeCevir()` parses comma-separated strings into `List<int>`.

### WindowsFormsApp2 — Number Analyzer
Single-form app testing numbers for prime (`AsalTesti`), perfect (`MukemmelTesti`), and palindrome (`PalindromTesti`) properties. `UygulaVeEkle()` dispatches based on `comboBox1.SelectedIndex`. A `Timer` control enables automatic random-number testing mode.

### WindowsFormsApp3 — Event Demo
Minimal project demonstrating control events (Click, MouseHover, MouseLeave, CheckedChanged, TextChanged, SelectedIndexChanged). Most handlers are intentionally empty stubs for student exercises.

### WindowsFormsApp4 — Grade Calculator
Single-form app: reads `txtVize` (midterm) and `txtFinal` grades, computes weighted average (`vize*0.4 + final*0.6`), displays result in `lblOrt` and pass/fail status in `lblDurum`.
