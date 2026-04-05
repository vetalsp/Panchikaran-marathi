# पंचीकरण — Panchikaran Web App

An interactive Blazor Web App exploring **Sartha Satik Panchikaran** —
Shankaracharya's Advaita Vedānta treatise on the fivefold combination of elements,
in its Marathi translation and commentary edition.

---

## Quick Start

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (v17.8+) **or** VS Code with C# Dev Kit

### Run in Visual Studio
1. Open `PanchikaranWeb.sln`
2. Set **PanchikaranWeb** as the startup project
3. Press **F5** (or Ctrl+F5 for without debugger)
4. Browser opens at `https://localhost:7245`

### Run from terminal
```bash
cd PanchikaranWeb
dotnet run
```

---

## Project Structure

```
PanchikaranWeb.sln
│
├── PanchikaranWeb/                        ← Server project (ASP.NET Core)
│   ├── Program.cs                         ← App setup, DI, routing
│   ├── Components/
│   │   ├── App.razor                      ← Root HTML, fonts, global render mode
│   │   ├── Routes.razor                   ← Router with WASM assembly
│   │   ├── Layout/
│   │   │   ├── MainLayout.razor           ← Sidebar + main content shell
│   │   │   └── NavMenu.razor              ← Sidebar navigation
│   │   └── Pages/
│   │       ├── Home.razor                 ← Landing page with hero + feature cards
│   │       ├── TableOfContents.razor      ← Filterable TOC with expandable entries
│   │       ├── PanchikaranDiagram.razor   ← 5-step interactive process explorer
│   │       ├── ConceptExplorer.razor      ← Card grid with category filter
│   │       ├── Glossary.razor             ← Searchable Sanskrit glossary (25 terms)
│   │       ├── Analogies.razor            ← 6 Drstantas with accordion
│   │       └── About.razor                ← Text background + Mahavakyas
│   ├── Data/
│   │   ├── BookContent.cs                 ← Data model classes
│   │   └── BookDataService.cs             ← All book content + query methods
│   └── wwwroot/
│       └── app.css                        ← Full design system (saffron/gold/cream)
│
└── PanchikaranWeb.Client/                 ← WebAssembly project
    ├── Program.cs
    └── _Imports.razor
```

---

## Features

| Page | What it does |
|------|-------------|
| **Home** | Hero with Devanagari title, feature cards, quote, and book statistics |
| **Table of Contents** | All 25 sections, filterable by category, click to expand with summary + key points |
| **Panchikaran Process** | 5-step interactive walkthrough: Tanmatras → Division → Mixing Table → Gross Elements → 9 Prakriyas |
| **Concept Explorer** | 25 concept cards in a responsive grid, filterable, expandable with shlokas |
| **Sanskrit Glossary** | 25 key terms, live search, category filter |
| **Dṛṣṭāntas** | 6 teaching analogies in an accordion — story, teaching, Vedic parallel |
| **About** | Text lineage, editorial note, four Mahavakyas |

---

## Architecture

- **Template**: Blazor Web App (not Blazor Server or standalone WASM)
- **Interactivity**: `InteractiveAuto` — renders on server first, upgrades to WASM
- **Scope**: Global (set in `App.razor` via `@rendermode="InteractiveAuto"`)
- **Data**: In-memory singleton `BookDataService` — all content seeded from the book
- **No JavaScript**: All interactivity (filters, accordions, step navigation) is pure C#

---

## Extending This Project

### Add more book sections
In `BookDataService.cs`, add to the `Sections` list:
```csharp
new() { Id = 26, TitleMarathi = "...", TitleEnglish = "...",
        Category = "Brahman", PageNumber = 195,
        Summary = "...",
        KeyPoints = new() { "Point 1", "Point 2" } },
```

### Add a new page
1. Create `Components/Pages/MyPage.razor` with `@page "/my-route"`
2. Add a `<NavLink>` entry in `NavMenu.razor`
3. Inject `@inject BookDataService BookData` if you need content

### Change the color theme
All colors are CSS variables in `wwwroot/app.css` under `:root { ... }`.
Swap `--saffron`, `--gold`, and `--brown-deep` to retheme the entire site.
