namespace PanchikaranWeb.Data;

public class BookSection
{
    public int Id { get; set; }
    public string TitleMarathi { get; set; } = "";
    public string TitleEnglish { get; set; } = "";
    public string Category { get; set; } = "";
    public int PageNumber { get; set; }
    public string Summary { get; set; } = "";
    public string SummaryMarathi { get; set; } = "";
    public List<string> KeyPoints { get; set; } = new();
    public List<string> KeyPointsMarathi { get; set; } = new();
    public string? Shloka { get; set; }
    public string? ShlokaTranslation { get; set; }
}

public class GlossaryEntry
{
    public int Id { get; set; }
    public string Sanskrit { get; set; } = "";
    public string Marathi { get; set; } = "";
    public string English { get; set; } = "";
    public string Definition { get; set; } = "";
    public string DefinitionMarathi { get; set; } = "";
    public string Category { get; set; } = "";
}

public class Drstanta
{
    public int Id { get; set; }
    public string TitleMarathi { get; set; } = "";
    public string TitleEnglish { get; set; } = "";
    public string Story { get; set; } = "";
    public string StoryMarathi { get; set; } = "";
    public string Teaching { get; set; } = "";
    public string TeachingMarathi { get; set; } = "";
    public string VedicParallel { get; set; } = "";
    public int PageNumber { get; set; }
}

public class Prakriya
{
    public int Number { get; set; }
    public string TitleMarathi { get; set; } = "";
    public string TitleEnglish { get; set; } = "";
    public string Description { get; set; } = "";
    public string DescriptionMarathi { get; set; } = "";
    public List<string> Components { get; set; } = new();
    public List<string> ComponentsMarathi { get; set; } = new();
    public int PageNumber { get; set; }
}

public class Element
{
    public string NameSanskrit { get; set; } = "";
    public string NameEnglish { get; set; } = "";
    public string Tanmatra { get; set; } = "";
    public string TanmatraMarathi { get; set; } = "";
    public string Sense { get; set; } = "";
    public string SenseMarathi { get; set; } = "";
    public string SenseOrgan { get; set; } = "";
    public string SenseOrganMarathi { get; set; } = "";
    public string ActionOrgan { get; set; } = "";
    public string ActionOrganMarathi { get; set; } = "";
    public string Color { get; set; } = "";
    public string Symbol { get; set; } = "";
}

// ── KOSHTAKA (TABLE) MODELS ─────────────────────────────────────────────────

public class Koshtaka
{
    public int Number { get; set; }
    public string TitleMarathi { get; set; } = "";
    public string TitleEnglish { get; set; } = "";
    public string Description { get; set; } = "";
    public string DescriptionMarathi { get; set; } = "";
    public int PageNumber { get; set; }
    public List<string> Headers { get; set; } = new();
    public List<string> HeadersMarathi { get; set; } = new();
    public List<List<string>> Rows { get; set; } = new();
    public string? Note { get; set; }
    public string? NoteMarathi { get; set; }
}
