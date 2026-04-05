namespace PanchikaranWeb.Data;

public class BookDataService
{
    public List<BookSection> GetAllSections() => Sections;
    public List<GlossaryEntry> GetGlossary() => Glossary;
    public List<Drstanta> GetDrstantas() => Drstantas;
    public List<Prakriya> GetPrakriyas() => Prakriyas;
    public List<Element> GetElements() => Elements;
    public List<Koshtaka> GetKoshtakas() => Koshtakas;

    public List<string> GetCategories() =>
        Sections.Select(s => s.Category).Distinct().OrderBy(c => c).ToList();

    public List<BookSection> GetSectionsByCategory(string category) =>
        Sections.Where(s => s.Category == category).ToList();

    // ─── PANCHABHUTAS / ELEMENTS ─────────────────────────────────────────────

    private static readonly List<Element> Elements = new()
    {
        new() {
            NameSanskrit = "आकाश", NameEnglish = "Akasha (Space/Ether)",
            Tanmatra = "Shabda (Sound)", TanmatraMarathi = "शब्द",
            Sense = "Hearing", SenseMarathi = "श्रवण",
            SenseOrgan = "Shrotra (Ears)", SenseOrganMarathi = "श्रोत्र (कान)",
            ActionOrgan = "Vak (Speech/Mouth)", ActionOrganMarathi = "वाक् (तोंड)",
            Color = "#9B59B6", Symbol = "∞"
        },
        new() {
            NameSanskrit = "वायु", NameEnglish = "Vayu (Air/Wind)",
            Tanmatra = "Sparsha (Touch)", TanmatraMarathi = "स्पर्श",
            Sense = "Touch", SenseMarathi = "स्पर्शज्ञान",
            SenseOrgan = "Tvak (Skin)", SenseOrganMarathi = "त्वचा (त्वचा)",
            ActionOrgan = "Pani (Hands)", ActionOrganMarathi = "पाणि (हात)",
            Color = "#3498DB", Symbol = "〜"
        },
        new() {
            NameSanskrit = "तेज", NameEnglish = "Tejas (Fire/Light)",
            Tanmatra = "Rupa (Form/Sight)", TanmatraMarathi = "रूप",
            Sense = "Sight", SenseMarathi = "दृष्टी",
            SenseOrgan = "Chakshu (Eyes)", SenseOrganMarathi = "चक्षू (डोळे)",
            ActionOrgan = "Pada (Feet)", ActionOrganMarathi = "पाद (पाय)",
            Color = "#E74C3C", Symbol = "△"
        },
        new() {
            NameSanskrit = "आप", NameEnglish = "Ap (Water)",
            Tanmatra = "Rasa (Taste)", TanmatraMarathi = "रस",
            Sense = "Taste", SenseMarathi = "चव",
            SenseOrgan = "Rasana (Tongue)", SenseOrganMarathi = "जिव्हा (जीभ)",
            ActionOrgan = "Upastha (Genitals)", ActionOrganMarathi = "शिश्र (उपस्थ)",
            Color = "#1ABC9C", Symbol = "▽"
        },
        new() {
            NameSanskrit = "पृथ्वी", NameEnglish = "Prithvi (Earth)",
            Tanmatra = "Gandha (Smell)", TanmatraMarathi = "गंध",
            Sense = "Smell", SenseMarathi = "गंधज्ञान",
            SenseOrgan = "Ghrana (Nose)", SenseOrganMarathi = "घ्राण (नाक)",
            ActionOrgan = "Payu (Anus)", ActionOrganMarathi = "गुद (गुद)",
            Color = "#F39C12", Symbol = "□"
        },
    };

    // ─── KOSHTAKAS (TABLES FROM THE BOOK) ────────────────────────────────────

    private static readonly List<Koshtaka> Koshtakas = new()
    {
        new()
        {
            Number = 1,
            TitleMarathi = "स्थूल देहाच्या तत्त्वांचे कोष्टक क्र. १",
            TitleEnglish = "Table of Gross Body Principles — Koshtaka No. 1",
            Description = "The gross body (Sthula Deha) is composed of 25 principles drawn from the five gross elements. This table maps each element to the five inner states (vritti) it governs.",
            DescriptionMarathi = "स्थूल देह पंचभूतांपासून बनलेला आहे. त्यात आकाशाची, वायूची, तेजाची, आपाची व पृथ्वीची प्रत्येकी पाच तत्त्वे आहेत.",
            PageNumber = 89,
            Headers = new() { "Element (Bhuta)", "Principle 1", "Principle 2", "Principle 3", "Principle 4", "Principle 5" },
            HeadersMarathi = new() { "भूत", "तत्त्व १", "तत्त्व २", "तत्त्व ३", "तत्त्व ४", "तत्त्व ५" },
            Rows = new()
            {
                new() { "आकाशाची (Akasha)", "काम (Kama/Desire)", "क्रोध (Krodha/Anger)", "शोक (Shoka/Grief)", "मोह (Moha/Delusion)", "भय (Bhaya/Fear)" },
                new() { "वायूची (Vayu)", "चलन (Chalana/Motion)", "वलन (Valana/Bending)", "धावन (Dhavana/Running)", "प्रसरण (Prasarana/Expansion)", "आकुंचन (Akunchana/Contraction)" },
                new() { "तेजाची (Tejas)", "क्षुधा (Kshudha/Hunger)", "तृषा (Trisha/Thirst)", "आलस्य (Alasya/Laziness)", "निद्रा (Nidra/Sleep)", "कांती (Kanti/Lustre)" },
                new() { "आपाची (Ap)", "शुक्र (Shukra/Semen)", "शोणित (Shonita/Blood)", "लाला (Lala/Saliva)", "मूत्र (Mutra/Urine)", "स्वेद (Sveda/Sweat)" },
                new() { "पृथ्वीची (Prithvi)", "अस्थी (Asthi/Bone)", "मांस (Mansa/Flesh)", "त्वचा (Tvaca/Skin)", "नाडी (Nadi/Nerve)", "रोम (Roma/Hair)" },
            },
            Note = "These 25 principles together constitute the gross physical body. They are the products of the five gross elements after Panchikaran.",
            NoteMarathi = "या पंचवीस तत्त्वांचा मिळून स्थूल देह बनलेला आहे. ही तत्त्वे पंचीकृत पंचमहाभूतांचे कार्य आहे."
        },

        new()
        {
            Number = 2,
            TitleMarathi = "स्थूल देहाच्या पंचीकृत पंचवीस तत्त्वे — कोष्टक क्र. २",
            TitleEnglish = "25 Principles of the Panchikrit Gross Body — Koshtaka No. 2",
            Description = "The 25 principles of the gross body shown through the fivefold combination — each element contributes 5 principles to the gross body.",
            DescriptionMarathi = "पंचीकृत पंचमहाभूतांपासून बनलेल्या स्थूल देहाची पंचवीस तत्त्वे.",
            PageNumber = 90,
            Headers = new() { "Category", "Sanskrit Name", "Function/Meaning", "Deity (Adhidaiva)" },
            HeadersMarathi = new() { "प्रकार", "संस्कृत नाव", "कार्य / अर्थ", "अधिदेव" },
            Rows = new()
            {
                new() { "ज्ञानेंद्रिय (Jnanendriya)", "श्रोत्र (Shrotra)", "Hearing — शब्द (Sound)", "दिशा (Disha)" },
                new() { "ज्ञानेंद्रिय (Jnanendriya)", "त्वचा (Tvaca)", "Touch — स्पर्श (Touch)", "वायू (Vayu)" },
                new() { "ज्ञानेंद्रिय (Jnanendriya)", "चक्षू (Chakshu)", "Sight — रूप (Form)", "सूर्य (Surya)" },
                new() { "ज्ञानेंद्रिय (Jnanendriya)", "जिव्हा (Jihva)", "Taste — रस (Taste)", "वरुण (Varuna)" },
                new() { "ज्ञानेंद्रिय (Jnanendriya)", "घ्राण (Ghrana)", "Smell — गंध (Smell)", "अश्विनीकुमार (Ashvini)" },
                new() { "कर्मेंद्रिय (Karmendriya)", "वाक् (Vak)", "Speech — वचन (Speaking)", "अग्नी (Agni)" },
                new() { "कर्मेंद्रिय (Karmendriya)", "पाणि (Pani)", "Grasping — आदान (Taking)", "इंद्र (Indra)" },
                new() { "कर्मेंद्रिय (Karmendriya)", "पाद (Pada)", "Locomotion — गमन (Walking)", "उपेंद्र (Upendra)" },
                new() { "कर्मेंद्रिय (Karmendriya)", "शिश्र (Shishra)", "Pleasure — आनंद (Delight)", "प्रजापती (Prajapati)" },
                new() { "कर्मेंद्रिय (Karmendriya)", "गुद (Guda)", "Elimination — विसर्ग (Excretion)", "यम (Yama)" },
                new() { "प्राण (Prana)", "प्राण", "Inward breath — heart region", "—" },
                new() { "प्राण (Prana)", "अपान", "Downward — elimination", "—" },
                new() { "प्राण (Prana)", "व्यान", "Circulation throughout body", "—" },
                new() { "प्राण (Prana)", "उदान", "Upward — speech, higher functions", "—" },
                new() { "प्राण (Prana)", "समान", "Digestion and assimilation", "—" },
                new() { "अंत:करण (Antahkarana)", "मन (Mana)", "Sankalpa — doubting, deliberating mind", "चंद्रमा (Chandra)" },
                new() { "अंत:करण (Antahkarana)", "बुद्धी (Buddhi)", "Nishchaya — determining intellect", "ब्रह्मा (Brahma)" },
                new() { "अंत:करण (Antahkarana)", "चित्त (Chitta)", "Chintana — memory, subconscious", "नारायण (Narayana)" },
                new() { "अंत:करण (Antahkarana)", "अहंकार (Ahamkara)", "Abhimana — the I-sense, ego", "रुद्र (Rudra)" },
            },
            Note = "The Antahkarana (inner instrument) has four functions: Manas (doubting), Buddhi (deciding), Chitta (remembering), and Ahamkara (ego). Together with the 5 Pranas, 5 Jnanendriyas, and 5 Karmendriyas, they form the 19-fold subtle body.",
            NoteMarathi = "अंत:करणाच्या चार वृत्ती: मन (संकल्प-विकल्प), बुद्धी (निश्चय), चित्त (चिंतन), अहंकार (अभिमान). या सर्वांचा मिळून सूक्ष्म देह बनतो."
        },

        new()
        {
            Number = 3,
            TitleMarathi = "जागृदवस्थेतील आठ तत्त्वांचे कोष्टक क्र. ३",
            TitleEnglish = "Eight Principles of the Waking State — Koshtaka No. 3",
            Description = "In the waking state (Jagrat Avastha), the Jiva operates through 8 sets of principles. Each sense organ, action organ, and inner faculty has its corresponding object (Vishaya) and presiding deity (Adhidaiva).",
            DescriptionMarathi = "जागृत अवस्थेत जीव ज्ञानेंद्रिये, कर्मेंद्रिये आणि अंत:करण यांच्या योगाने व्यवहार करतो.",
            PageNumber = 100,
            Headers = new() { "Adhyatma (Inner Organ)", "Vishaya (Object)", "Adhidaiva (Deity)" },
            HeadersMarathi = new() { "अध्यात्म", "विषय", "अधिदैव" },
            Rows = new()
            {
                new() { "श्रोत्र (Shrotra/Ear)", "शब्द (Shabda/Sound)", "दिशा (Disha/Directions)" },
                new() { "त्वचा (Tvaca/Skin)", "स्पर्श (Sparsha/Touch)", "वायू (Vayu/Air)" },
                new() { "चक्षू (Chakshu/Eye)", "रूप (Rupa/Form)", "सूर्य (Surya/Sun)" },
                new() { "जिव्हा (Jihva/Tongue)", "रस (Rasa/Taste)", "वरुण (Varuna/Water-god)" },
                new() { "घ्राण (Ghrana/Nose)", "गंध (Gandha/Smell)", "अश्विनीकुमार" },
                new() { "वाक् (Vak/Speech)", "वचन (Vachana/Speaking)", "अग्नी (Agni/Fire)" },
                new() { "पाणि (Pani/Hands)", "आदान (Adana/Grasping)", "इंद्र (Indra)" },
                new() { "पाद (Pada/Feet)", "गमन (Gamana/Walking)", "उपेंद्र (Upendra)" },
                new() { "शिश्र (Shishra)", "आनंद (Ananda/Pleasure)", "प्रजापती (Prajapati)" },
                new() { "गुद (Guda/Anus)", "विसर्ग (Visarga/Excretion)", "मृत्यू (Mrityu/Death)" },
                new() { "मन (Mana/Mind)", "संकल्प (Sankalpa/Will)", "चंद्रमा (Chandra/Moon)" },
                new() { "बुद्धी (Buddhi/Intellect)", "निश्चय (Nishchaya/Decision)", "ब्रह्मा (Brahma)" },
                new() { "चित्त (Chitta/Memory)", "चिंतन (Chintana/Thought)", "नारायण (Narayana)" },
                new() { "अहंकार (Ahamkara/Ego)", "अभिमान (Abhimana/Pride)", "रुद्र (Rudra)" },
            },
            Note = "In the waking state, all 14 instruments (5 Jnanendriyas, 5 Karmendriyas, 4 Antahkaranas) are active. The Self (Atman) is the silent witness behind all these activities.",
            NoteMarathi = "जागृत अवस्थेत चौदाही तत्त्वे कार्यरत असतात. आत्मा त्या सर्वांचा साक्षी आहे."
        },

        new()
        {
            Number = 4,
            TitleMarathi = "ज्ञानेंद्रिय त्रिपुटी कोष्टक क्र. ४",
            TitleEnglish = "Triputi of Sense Organs — Koshtaka No. 4",
            Description = "Each sense organ forms a Triputi (triad) of three: the inner instrument (Adhyatma), its object (Adhibhuta), and its presiding deity (Adhidaiva). The action of perception requires all three to be present.",
            DescriptionMarathi = "प्रत्येक ज्ञानेंद्रियाची त्रिपुटी — अध्यात्म, अधिभूत आणि अधिदैव — या तिन्ही मिळून एकच क्रिया घडते.",
            PageNumber = 110,
            Headers = new() { "Adhyatma (Inner)", "Adhibhuta (Object)", "Adhidaiva (Deity)" },
            HeadersMarathi = new() { "अध्यात्म", "अधिभूत", "अधिदैव" },
            Rows = new()
            {
                new() { "श्रोत्र (Hearing organ)", "शब्द (Sound)", "दिशा (Directions)" },
                new() { "त्वचा (Touch organ)", "स्पर्श (Touch)", "वायू (Air-god)" },
                new() { "चक्षू (Sight organ)", "रूप (Form)", "सूर्य (Sun)" },
                new() { "जिव्हा (Taste organ)", "रस (Taste)", "वरुण (Water-god)" },
                new() { "घ्राण (Smell organ)", "गंध (Smell)", "अश्विनीकुमार" },
            },
            Note = "Example: The eye (Chakshu-Adhyatma) sees form (Rupa-Adhibhuta) because the Sun (Surya-Adhidaiva) illuminates it. If any one of the three is absent, perception cannot occur.",
            NoteMarathi = "उदाहरण: चक्षू अध्यात्म आहे, रूप अधिभूत आहे, परंतु अधिदैव सूर्य जर नसेल तर जीवास दिसावयाचे नाही."
        },

        new()
        {
            Number = 5,
            TitleMarathi = "कर्मेंद्रिय त्रिपुटी कोष्टक क्र. ५",
            TitleEnglish = "Triputi of Action Organs — Koshtaka No. 5",
            Description = "Each action organ (Karmendriya) similarly forms a triad of inner instrument, object of action, and presiding deity. Without all three, action cannot occur.",
            DescriptionMarathi = "प्रत्येक कर्मेंद्रियाची त्रिपुटी — अध्यात्म, अधिभूत आणि अधिदैव.",
            PageNumber = 111,
            Headers = new() { "Adhyatma (Inner)", "Adhibhuta (Object)", "Adhidaiva (Deity)" },
            HeadersMarathi = new() { "अध्यात्म", "अधिभूत", "अधिदैव" },
            Rows = new()
            {
                new() { "वाक् (वचन — Speech)", "वचन (बोलणे)", "अग्नी (Agni)" },
                new() { "पाणि (हात — Hands)", "आदान (देणे घेणे)", "इंद्र (Indra)" },
                new() { "पाद (पाय — Feet)", "गमन (जाणे येणे)", "उपेंद्र (Upendra)" },
                new() { "शिश्र (उपस्थ)", "आनंद (रतिभोग)", "प्रजापती (Prajapati)" },
                new() { "गुद (Anus)", "विसर्ग (मलत्याग)", "यम (Yama)" },
            },
            Note = "Example: Speech (Vak-Adhyatma) produces sound (Vachana-Adhibhuta) through the power of Agni (Adhidaiva). All three must be present for speech to occur.",
            NoteMarathi = "वागींद्रिय अध्यात्म, वचन अधिभूत आणि अग्नी अधिदैव या त्रिपुटीच्या योगानेच शब्द बोलण्याची क्रिया घडते."
        },

        new()
        {
            Number = 6,
            TitleMarathi = "सान्विक भागांच्या तत्त्वांचे कोष्टक क्र. ६",
            TitleEnglish = "Principles of the Saattvika Elements — Koshtaka No. 6",
            Description = "This table maps the Saattvika portions of the subtle body: the four Antahkarana functions and their corresponding deities in the three realms — Adhyatma (inner), Adhibhuta (outer world), and Adhidaiva (celestial).",
            DescriptionMarathi = "अंत:करणाच्या चार वृत्ती व त्यांचे अध्यात्म, अधिभूत आणि अधिदैव यांचे कोष्टक.",
            PageNumber = 123,
            Headers = new() { "Antahkarana", "Adhyatma Function", "Adhibhuta (Outer)", "Adhidaiva (Deity)" },
            HeadersMarathi = new() { "अंत:करण", "अध्यात्म कार्य", "अधिभूत", "अधिदैव" },
            Rows = new()
            {
                new() { "मन (Mana)", "संकल्प-विकल्प (Doubt/Will)", "चंद्रमा (Moon)", "Moon governs the doubting mind" },
                new() { "बुद्धी (Buddhi)", "निश्चय (Determination)", "ब्रह्मा (Brahma)", "Brahma governs the determining intellect" },
                new() { "चित्त (Chitta)", "चिंतन (Contemplation)", "नारायण (Narayana)", "Narayana governs memory and reflection" },
                new() { "अहंकार (Ahamkara)", "अभिमान (Ego-sense)", "रुद्र (Rudra)", "Rudra governs the sense of doership" },
            },
            Note = "The four Antahkarana faculties correspond to different planes of reality. The ego (Ahamkara) is the root of bondage; its dissolution under Rudra's grace leads to liberation.",
            NoteMarathi = "अहंकाराचा नाश हाच मोक्ष आहे. बुद्धीने निश्चय करणे, मनाने ध्यान करणे, चित्ताने परमात्म्याचे चिंतन करणे हे मुक्तीचे उपाय आहेत."
        },
    };

    // ─── PRAKRIYAS ────────────────────────────────────────────────────────────

    private static readonly List<Prakriya> Prakriyas = new()
    {
        new() {
            Number = 1, TitleMarathi = "प्रक्रिया पहिली", TitleEnglish = "First Process",
            Description = "Describes the five gross elements (Panchamahabhutas) in their undivided, pure state before combination, establishing the ontological foundation of creation.",
            DescriptionMarathi = "पंचमहाभूते — आकाश, वायू, तेज, आप आणि पृथ्वी — यांचे विवेचन. पंचीकरणापूर्वीची त्यांची शुद्ध अवस्था.",
            Components = new() { "Akasha (Space)", "Vayu (Air)", "Tejas (Fire)", "Ap (Water)", "Prithvi (Earth)" },
            ComponentsMarathi = new() { "आकाश", "वायू", "तेज", "आप", "पृथ्वी" },
            PageNumber = 112
        },
        new() {
            Number = 2, TitleMarathi = "प्रक्रिया दुसरी", TitleEnglish = "Second Process",
            Description = "Describes the five subtle elements (Tanmatras) — the pure essences of each element: sound, touch, form, taste, and smell — which are the causal seeds of the gross elements.",
            DescriptionMarathi = "पाच तन्मात्रांचे वर्णन — शब्द, स्पर्श, रूप, रस आणि गंध. या सूक्ष्म बीजांपासूनच पंचमहाभूते उत्पन्न होतात.",
            Components = new() { "Shabda (Sound)", "Sparsha (Touch)", "Rupa (Form)", "Rasa (Taste)", "Gandha (Smell)" },
            ComponentsMarathi = new() { "शब्द", "स्पर्श", "रूप", "रस", "गंध" },
            PageNumber = 113
        },
        new() {
            Number = 3, TitleMarathi = "प्रक्रिया तिसरी — पंचीकरण", TitleEnglish = "Third Process — Panchikaran",
            Description = "The central teaching: each subtle element divides into two halves. One half remains unchanged; the other is subdivided into four ⅛ parts distributed among the other four elements. This produces the five gross elements.",
            DescriptionMarathi = "मुख्य प्रक्रिया: प्रत्येक भूताचे दोन भाग होतात. एक भाग निराळा राहतो, दुसऱ्याचे चार भाग करून प्रत्येक भाग चार भूतांना दिला जातो. याला पंचीकरण म्हणतात.",
            Components = new() { "Each element splits: ½ remains pure", "½ splits into 4 × ⅛ parts", "Each ⅛ joins the other 4 elements", "Result: 5 gross Mahābhūtas" },
            ComponentsMarathi = new() { "प्रत्येक भूताचे अर्धे भाग निराळे", "उरलेल्या अर्ध्याचे चार भाग", "प्रत्येक ⅛ भाग चार भूतांना", "परिणाम: पाच स्थूल महाभूते" },
            PageNumber = 119
        },
        new() {
            Number = 4, TitleMarathi = "प्रक्रिया चवथी", TitleEnglish = "Fourth Process",
            Description = "Description of the gross body (Sthula Sharira) — its 25 constituent principles derived from the gross elements, including the five sense organs, five action organs, five vital breaths, and the fourfold inner instrument.",
            DescriptionMarathi = "स्थूल शरीराचे वर्णन — पंचज्ञानेंद्रिये, पंचकर्मेंद्रिये, पंचप्राण आणि चतुरंत:करण असे पंचवीस घटक.",
            Components = new() { "5 Jnanendriyas (sense organs)", "5 Karmendriyas (action organs)", "5 Pranas (vital breaths)", "4 Antahkaranas (Manas, Buddhi, Chitta, Ahamkara)" },
            ComponentsMarathi = new() { "५ ज्ञानेंद्रिये", "५ कर्मेंद्रिये", "५ प्राण", "४ अंत:करणे (मन, बुद्धी, चित्त, अहंकार)" },
            PageNumber = 122
        },
        new() {
            Number = 5, TitleMarathi = "प्रक्रिया पाचवी", TitleEnglish = "Fifth Process",
            Description = "Detailed exposition of the subtle body (Sukshma Sharira) — the 17-fold instrument that transmigrates after death and forms the link between successive embodiments.",
            DescriptionMarathi = "सूक्ष्म शरीर — लिंगदेह — हा सतरा घटकांचा बनलेला आहे. मृत्यूनंतर हा देह पुढे जातो आणि पुनर्जन्मास कारण होतो.",
            Components = new() { "5 Jnanendriyas", "5 Pranas", "4 Antahkaranas", "3 Gunas as substrate" },
            ComponentsMarathi = new() { "५ ज्ञानेंद्रिये", "५ प्राण", "४ अंत:करणे", "गुण-त्रयी" },
            PageNumber = 124
        },
        new() {
            Number = 6, TitleMarathi = "प्रक्रिया सहावी", TitleEnglish = "Sixth Process",
            Description = "Exposition of the causal body (Karana Sharira) — the state of deep sleep (Sushupti) and primordial ignorance (Avidya) that is the seed-form of the other two bodies.",
            DescriptionMarathi = "कारण शरीर — अज्ञान — हा सर्वांत सूक्ष्म देह आहे. सुषुप्ती अवस्थेत हेच प्रकट होते. हेच स्थूल व सूक्ष्म देहांचे बीज आहे.",
            Components = new() { "Avidya (primordial ignorance)", "Anandamaya Kosha (bliss sheath)", "Deep sleep state (Sushupti)", "Seed of the other two bodies" },
            ComponentsMarathi = new() { "अविद्या (अज्ञान)", "आनंदमय कोश", "सुषुप्ती अवस्था", "स्थूल-सूक्ष्म देहांचे कारण" },
            PageNumber = 127
        },
        new() {
            Number = 7, TitleMarathi = "प्रक्रिया सातवी", TitleEnglish = "Seventh Process",
            Description = "Description of the three states of experience (Avasthatraya) — waking (Jagrat), dreaming (Svapna), and deep sleep (Sushupti) — and the witnessing Self (Sakshi) that illumines them all.",
            DescriptionMarathi = "जागृत, स्वप्न आणि सुषुप्ती या तीन अवस्थांचे वर्णन. आत्मा या तिन्हींचा साक्षी असतो — त्याला तुरीय म्हणतात.",
            Components = new() { "Jagrat (waking state)", "Svapna (dream state)", "Sushupti (deep sleep)", "Turiya — the witnessing Fourth" },
            ComponentsMarathi = new() { "जागृत अवस्था", "स्वप्न अवस्था", "सुषुप्ती अवस्था", "तुरीय — साक्षी आत्मा" },
            PageNumber = 129
        },
        new() {
            Number = 8, TitleMarathi = "प्रक्रिया आठवी — तत्त्वमसि", TitleEnglish = "Eighth Process — Tat Tvam Asi",
            Description = "The teaching of Tat Tvam Asi — 'That Thou Art' — the great Vedic declaration. Three kinds of Lakshana (implied meaning): Jahadajahallakshana, Jahallakshana, and Ajahallakshana.",
            DescriptionMarathi = "तत्त्वमसि महावाक्याचे विवेचन. 'तत्' म्हणजे ब्रह्म, 'त्वम्' म्हणजे जीव, 'असि' म्हणजे अभिन्नता. भागत्यागलक्षणेने जीव-ब्रह्माची एकता सिद्ध होते.",
            Components = new() { "Tat = Brahman (Pure Consciousness)", "Tvam = Jiva (individual self)", "Asi = identity (are)", "Bhaga-tyaga-lakshana method" },
            ComponentsMarathi = new() { "तत् = ब्रह्म", "त्वम् = जीव", "असि = एकता", "भागत्यागलक्षणा" },
            PageNumber = 131
        },
        new() {
            Number = 9, TitleMarathi = "प्रक्रिया नववी — अद्वैत ब्रह्म", TitleEnglish = "Ninth Process — Advaita Brahman",
            Description = "Description of Advaita Brahman as Sat-Chit-Ananda (Existence-Consciousness-Bliss). The means of liberation: Sravana, Manana, Nididhyasana, culminating in Nirvikalpa Samadhi.",
            DescriptionMarathi = "अद्वैत ब्रह्माचे वर्णन — सत्-चित्-आनंद. मुक्तीचे उपाय: श्रवण, मनन, निदिध्यासन, निर्विकल्प समाधी.",
            Components = new() { "Sat (Pure Existence)", "Chit (Pure Consciousness)", "Ananda (Pure Bliss)", "Shravana → Manana → Nididhyasana → Samadhi" },
            ComponentsMarathi = new() { "सत् (शुद्ध अस्तित्व)", "चित् (शुद्ध चेतना)", "आनंद (शुद्ध आनंद)", "श्रवण → मनन → निदिध्यासन → समाधी" },
            PageNumber = 132
        },
    };

    // ─── DRSTANTAS ────────────────────────────────────────────────────────────

    private static readonly List<Drstanta> Drstantas = new()
    {
        new() {
            Id = 1, TitleMarathi = "अंधळ्याचा दृष्टान्त", TitleEnglish = "The Blind Man Analogy",
            StoryMarathi = "जन्मापासून अंध असलेल्या माणसाला जग दिसत नाही, परंतु जग आहे. त्याला मार्गदर्शक लागतो. दृष्टी मिळाल्यावर त्याला जे होते ते नव्याने दिसते असे नाही — जे आधीपासून होते तेच दिसते.",
            Story = "A man blind from birth cannot see the world, yet the world fully exists. He needs a guide to navigate. When sight is restored, he does not discover something new — he sees what was always there.",
            TeachingMarathi = "अज्ञानामुळे आत्मा दिसत नाही, परंतु आत्मा आहे. गुरू मार्गदर्शक आहे. आत्मज्ञानाने नवीन आत्मा निर्माण होत नाही — जे आधीपासून होते ते प्रकट होते.",
            Teaching = "The Self is not seen due to ignorance (Avidya), but the Self fully exists. The Guru acts as guide. Self-knowledge does not create a new Self — it reveals what was always there.",
            VedicParallel = "Jnanat eva tu kaivalyam — Liberation comes from knowledge alone.",
            PageNumber = 36
        },
        new() {
            Id = 2, TitleMarathi = "सिंहाचा दृष्टान्त — स्वरूपविस्मरण", TitleEnglish = "The Lion Cub Analogy",
            StoryMarathi = "मेंढ्यांत वाढलेला सिंहाचा पिल्ला स्वत:ला मेंढा समजतो. एक दिवस पर्वतातील सिंह त्याला नदीत प्रतिबिंब दाखवतो व गर्जना करतो. त्या क्षणी पिल्लाला स्वत:चे खरे स्वरूप कळते.",
            Story = "A lion cub raised among sheep believes itself to be a sheep — it bleats, grazes, and trembles. One day, an elder lion shows it its own reflection in a river and roars. Instantly the cub recognises its true nature.",
            TeachingMarathi = "जीव उपाधींमुळे स्वत:ला देहमन समजतो. गुरूचे 'तत्त्वमसि' हे वचन आरशासारखे आहे — त्याने स्वत:चे ब्रह्मस्वरूप ओळखतो.",
            Teaching = "The Jiva mistakes itself for the body-mind due to Avidya and Upadhi. The Guru's 'Tat Tvam Asi' acts as the mirror — the student instantly recognises their true nature as Brahman.",
            VedicParallel = "Aham Brahmasmi — I am Brahman.",
            PageNumber = 29
        },
        new() {
            Id = 3, TitleMarathi = "स्वदेशी जाणाऱ्या पुष्पाचा दृष्टान्त", TitleEnglish = "The Foreign Flower Analogy",
            StoryMarathi = "परदेशातून आलेल्या फुलाला इथले लोक वेगळे नाव देतात. परंतु त्या फुलाचे खरे स्वरूप नावाने बदलत नाही.",
            Story = "A flower arriving from a foreign land is given a local name by the people there. But the true nature of the flower does not change based on the name given to it.",
            TeachingMarathi = "ब्रह्म विविध नावे व रूपे धारण करते, परंतु त्याचे खरे स्वरूप अपरिवर्तित राहते. नामरूप हे अध्यास आहेत.",
            Teaching = "Brahman appears under different names and forms across the universe, yet its essential nature remains unchanged. Names and forms (Nama-Rupa) are superimpositions.",
            VedicParallel = "Ekam sat vipra bahudha vadanti — Truth is one; the wise call it by many names.",
            PageNumber = 42
        },
        new() {
            Id = 4, TitleMarathi = "गुहेच्या अंधकाराचा दृष्टान्त", TitleEnglish = "The Cave of Darkness Analogy",
            StoryMarathi = "शेकडो वर्षांचा अंधार असलेल्या गुहेत एक दिवा नेला की सारा अंधार क्षणात नाहीसा होतो. अंधार किती जुना होता याचा काही उपयोग होत नाही.",
            Story = "Centuries of darkness in a cave are dispelled instantly when a single lamp is brought in. The duration of the darkness offers no resistance to the light.",
            TeachingMarathi = "अनेक जन्मांचे अज्ञान — अविद्या — आत्मज्ञानाने क्षणात नाश पावते. अज्ञानाचा काळ आत्मज्ञानाला अडथळा करू शकत नाही.",
            Teaching = "Ignorance (Avidya), even if accumulated over countless lifetimes, is removed instantly upon the dawn of Self-knowledge. Duration of ignorance offers no resistance to the light of wisdom.",
            VedicParallel = "Jnanat eva tu kaivalyam — Liberation comes from knowledge alone.",
            PageNumber = 59
        },
        new() {
            Id = 5, TitleMarathi = "मंदिराच्या धुमटाचा दृष्टान्त", TitleEnglish = "The Temple Lamp Analogy",
            StoryMarathi = "मंदिराच्या गाभाऱ्यातील दिवा देवतेला, पुजाऱ्याला, भिंतींना आणि भक्तांना सारखाच प्रकाश देतो — भेदभाव न करता. तो दिवा स्वत: मात्र त्यात सहभागी होत नाही.",
            Story = "The lamp in the innermost sanctum of a temple illumines the deity, the priest, the walls, and all worshippers equally and without distinction. The lamp itself remains uninvolved.",
            TeachingMarathi = "ब्रह्म, शुद्ध चेतनारूप, जागृत, स्वप्न आणि सुषुप्ती या तिन्ही अवस्थांना प्रकाशित करतो — परंतु त्यात सहभागी होत नाही. आत्मा सर्वांचा साक्षी आहे.",
            Teaching = "Brahman as Pure Consciousness (Chit) illumines all three states equally without being affected. The Self is the witness (Sakshi) — ever present, never participating.",
            VedicParallel = "Prajnanam Brahma — Consciousness is Brahman.",
            PageNumber = 62
        },
        new() {
            Id = 6, TitleMarathi = "विष्णुदत्त सावकाराचा दृष्टान्त", TitleEnglish = "The Moneylender Vishnudatta",
            StoryMarathi = "विष्णुदत्त नावाच्या सावकाराने अनेकांना पैसे दिले होते. त्याच्या मृत्यूनंतरही तो त्या देण्या-घेण्यांच्या आसक्तीमुळे भटकत राहिला.",
            Story = "A moneylender named Vishnudatta lent money to many people. After death, he remained bound to the world through his attachments to unpaid debts, his ghost unable to rest.",
            TeachingMarathi = "इच्छा आणि आसक्ती (वासना) जीवाला जन्मोजन्मी बांधतात. केवळ आत्मज्ञानाने — इच्छांच्या पूर्ण नाशाने — मोक्ष मिळतो.",
            Teaching = "Desire and attachment (Vasana) bind the Jiva across lifetimes. Only the complete dissolution of desires through Self-knowledge leads to Moksha.",
            VedicParallel = "Kama eva iha kalmashaha — Desire alone is the impurity in this world.",
            PageNumber = 52
        },
    };

    // ─── GLOSSARY ─────────────────────────────────────────────────────────────

    private static readonly List<GlossaryEntry> Glossary = new()
    {
        new() { Id=1, Sanskrit="आत्मन्", Marathi="आत्मा", English="Atman", Category="Core Concepts",
                Definition="The innermost Self — Pure Consciousness that is the true nature of every being. Identical with Brahman.",
                DefinitionMarathi="प्रत्येक प्राण्याचे खरे स्वरूप — शुद्ध चेतना. ब्रह्माशी अभिन्न." },
        new() { Id=2, Sanskrit="ब्रह्मन्", Marathi="ब्रह्म", English="Brahman", Category="Core Concepts",
                Definition="The Absolute Reality — infinite, self-luminous, non-dual Pure Consciousness. The one without a second.",
                DefinitionMarathi="परम सत्य — अनंत, स्वयंप्रकाश, अद्वैत शुद्ध चेतना. एकमेव, द्वितीय नाही." },
        new() { Id=3, Sanskrit="पंचीकरण", Marathi="पंचीकरण", English="Panchikaran", Category="Core Concepts",
                Definition="The fivefold combination: each subtle element gives ½ of itself and receives ⅛ each from the other four, producing the five gross elements.",
                DefinitionMarathi="प्रत्येक सूक्ष्म भूताचे दोन भाग होतात — अर्धे स्वत:चे राहते, उरलेल्याचे चार भाग होऊन इतर चार भूतांना दिले जातात." },
        new() { Id=4, Sanskrit="माया", Marathi="माया", English="Maya", Category="Core Concepts",
                Definition="The cosmic power of illusion that makes Brahman appear as the world of multiplicity. Neither real nor unreal — inexplicable (Anirvachaniya).",
                DefinitionMarathi="ब्रह्माला नाम-रूप देणारी शक्ती. ती सत् नाही, असत् नाही — अनिर्वचनीय आहे." },
        new() { Id=5, Sanskrit="अविद्या", Marathi="अज्ञान", English="Avidya", Category="Core Concepts",
                Definition="Individual ignorance — the superimposition of the non-Self upon the Self. The root cause of all suffering and bondage.",
                DefinitionMarathi="व्यक्तिगत अज्ञान — आत्म्यावर अनात्म्याचा अध्यास. सर्व दुःखाचे मूळ कारण." },
        new() { Id=6, Sanskrit="विवेक", Marathi="विवेक", English="Viveka", Category="Sadhana",
                Definition="Discrimination — the capacity to distinguish between the Real (Nitya) and the unreal (Anitya), between Self and non-Self.",
                DefinitionMarathi="नित्य-अनित्य, आत्मा-अनात्मा यांच्यात भेद करण्याची क्षमता. पहिले साधन." },
        new() { Id=7, Sanskrit="वैराग्य", Marathi="वैराग्य", English="Vairagya", Category="Sadhana",
                Definition="Dispassion — absence of craving for enjoyments of this world and the next, born from recognizing their impermanence.",
                DefinitionMarathi="या लोकातले व परलोकातले भोगांसंबंधाने इच्छा राहिल्या (इच्छेचा अभाव) — त्याचे नाव वैराग्य." },
        new() { Id=8, Sanskrit="मुमुक्षुता", Marathi="मुमुक्षा", English="Mumukshatva", Category="Sadhana",
                Definition="The burning desire for liberation — the intense longing to be free from birth and death, stronger than all other desires.",
                DefinitionMarathi="मोक्षाची तीव्र इच्छा — सर्व इच्छांपेक्षा बलवान असलेली मुक्तीची आकांक्षा." },
        new() { Id=9, Sanskrit="सत्-चित्-आनन्द", Marathi="सत्-चित्-आनंद", English="Sat-Chit-Ananda", Category="Core Concepts",
                Definition="Existence-Consciousness-Bliss — the threefold description of Brahman's nature. Not three qualities but one indivisible Reality.",
                DefinitionMarathi="अस्तित्व-ज्ञान-आनंद — ब्रह्माचे त्रिविध वर्णन. या तीन वेगळ्या नाहीत — एकच अखंड सत्य." },
        new() { Id=10, Sanskrit="तत्त्वमसि", Marathi="तत्त्वमसि", English="Tat Tvam Asi", Category="Mahavakya",
                Definition="'That Thou Art' — from the Chandogya Upanishad. Declares the absolute identity of the individual Jiva and Brahman.",
                DefinitionMarathi="'तू तेच आहेस' — छांदोग्य उपनिषदातील महावाक्य. जीव आणि ब्रह्म यांची अभिन्नता सांगते." },
        new() { Id=11, Sanskrit="अहं ब्रह्मास्मि", Marathi="अहं ब्रह्मास्मि", English="Aham Brahmasmi", Category="Mahavakya",
                Definition="'I am Brahman' — the Mahavakya from the Brihadaranyaka Upanishad. The direct assertion of the Self's identity with the Absolute.",
                DefinitionMarathi="'मी ब्रह्म आहे' — बृहदारण्यक उपनिषदातील महावाक्य. आत्म्याची ब्रह्माशी अभिन्नता." },
        new() { Id=12, Sanskrit="अंत:करण", Marathi="अंत:करण", English="Antahkarana", Category="Subtle Body",
                Definition="The fourfold inner instrument: Manas (doubting mind), Buddhi (intellect), Chitta (memory), Ahamkara (ego).",
                DefinitionMarathi="मन, बुद्धी, चित्त, अहंकार — या चार अंत:करणांचा एकत्र व्यवहार म्हणजे मन." },
        new() { Id=13, Sanskrit="पंचमहाभूत", Marathi="पंचमहाभूते", English="Pancha Mahabhuta", Category="Elements",
                Definition="The five great elements — Akasha (Space), Vayu (Air), Tejas (Fire), Ap (Water), Prithvi (Earth) — that constitute all gross matter after Panchikaran.",
                DefinitionMarathi="आकाश, वायू, तेज, आप, पृथ्वी — पंचीकरणानंतर निर्माण झालेले पाच स्थूल महाभूते." },
        new() { Id=14, Sanskrit="तन्मात्र", Marathi="तन्मात्र", English="Tanmatra", Category="Elements",
                Definition="The five subtle essences — Shabda, Sparsha, Rupa, Rasa, Gandha — causal precursors of the five gross elements before Panchikaran.",
                DefinitionMarathi="शब्द, स्पर्श, रूप, रस, गंध — पाच तन्मात्रे. पंचीकरणापूर्वीची सूक्ष्म भूतांची शुद्ध अवस्था." },
        new() { Id=15, Sanskrit="समाधि", Marathi="समाधी", English="Samadhi", Category="Liberation",
                Definition="Complete meditative absorption. Savikalpa Samadhi retains subtle distinctions; Nirvikalpa Samadhi is pure undivided Consciousness.",
                DefinitionMarathi="सविकल्प समाधीत त्रिपुटी असते; निर्विकल्प समाधीत शुद्ध अखंड चेतना असते." },
        new() { Id=16, Sanskrit="गुरु", Marathi="गुरु", English="Guru", Category="Sadhana",
                Definition="The realized spiritual teacher competent to transmit Self-knowledge to a qualified student. The Guru is identified with Brahman itself.",
                DefinitionMarathi="आत्मसाक्षात्कार झालेला सद्गुरू जो योग्य शिष्याला आत्मज्ञान देऊ शकतो. गुरू हेच ब्रह्म आहे." },
        new() { Id=17, Sanskrit="जीव", Marathi="जीव", English="Jiva", Category="Core Concepts",
                Definition="The individual soul — Brahman reflected in the Antahkarana, appearing bound due to identification with the body-mind.",
                DefinitionMarathi="अंत:करणात प्रतिबिंबित झालेला आत्मा. उपाधींमुळे बद्ध वाटतो, परंतु खरा अर्थाने मुक्तच आहे." },
        new() { Id=18, Sanskrit="उपाधि", Marathi="उपाधी", English="Upadhi", Category="Core Concepts",
                Definition="Limiting adjunct — the body, mind, and ego that appear to limit the infinite Self, like coloured glass tinting colourless light.",
                DefinitionMarathi="देह, मन, अहंकार — जे अनंत आत्म्याला मर्यादित वाटायला लावतात. रंगीत काचेसारखे." },
        new() { Id=19, Sanskrit="मोक्ष", Marathi="मोक्ष", English="Moksha", Category="Liberation",
                Definition="Liberation — permanent cessation of the cycle of birth and death through direct recognition of one's identity with Brahman.",
                DefinitionMarathi="जन्ममृत्यूच्या चक्रातून कायमची मुक्ती. ब्रह्माशी अभिन्नतेच्या साक्षात्काराने." },
        new() { Id=20, Sanskrit="कर्म", Marathi="कर्म", English="Karma", Category="Core Concepts",
                Definition="Action and its residual impression. Ego-driven actions create Samskaras that condition future experience and rebirth.",
                DefinitionMarathi="अहंकाराने केलेले कर्म संस्कार निर्माण करते जे भावी जन्माला कारण होते." },
        new() { Id=21, Sanskrit="श्रवण", Marathi="श्रवण", English="Shravana", Category="Sadhana",
                Definition="Hearing — the first of three disciplines of Jnana Yoga: systematic attentive listening to the Upanishadic teaching from a qualified Guru.",
                DefinitionMarathi="ज्ञानयोगाचे पहिले साधन — सद्गुरूकडून उपनिषदांचे सावधपणे श्रवण." },
        new() { Id=22, Sanskrit="मनन", Marathi="मनन", English="Manana", Category="Sadhana",
                Definition="Reflection — the second discipline: repeatedly turning the teaching in the intellect to remove doubts until it becomes firm conviction.",
                DefinitionMarathi="दुसरे साधन — ऐकलेल्या शिकवणीवर वारंवार विचार करून शंका दूर करणे." },
        new() { Id=23, Sanskrit="निदिध्यासन", Marathi="निदिध्यासन", English="Nididhyasana", Category="Sadhana",
                Definition="Contemplation — the third discipline: sustained deep meditation on the truth until all contrary habitual thought patterns (Vasanas) are dissolved.",
                DefinitionMarathi="तिसरे साधन — सत्याचे दीर्घ ध्यान करणे जेणेकरून सर्व विरोधी वासना नाश पावतात." },
        new() { Id=24, Sanskrit="सत्संग", Marathi="सत्संग", English="Satsanga", Category="Sadhana",
                Definition="Company of Truth — being in the presence of a Self-realized sage or devoted seekers. The highest accelerant of spiritual development.",
                DefinitionMarathi="साधुसमागम — आत्मज्ञानी महात्म्याचा सहवास. आध्यात्मिक उन्नतीचा सर्वोत्तम उपाय." },
        new() { Id=25, Sanskrit="वासना", Marathi="वासना", English="Vasana", Category="Subtle Body",
                Definition="Subtle impressions left by past actions and experiences stored in the Chitta, driving future desires, actions, and rebirths.",
                DefinitionMarathi="चित्तात साठलेले भूतकालीन कर्मांचे सूक्ष्म संस्कार. भविष्यातील इच्छा व पुनर्जन्माचे कारण." },
        new() { Id=26, Sanskrit="शमदमादी षट्संपत्ती", Marathi="षट्संपत्ती", English="Shat-Sampatti", Category="Sadhana",
                Definition="The sixfold inner wealth required for Vedanta study: Shama, Dama, Uparama, Titiksha, Shraddha, and Samadhana.",
                DefinitionMarathi="वेदान्त अभ्यासासाठी आवश्यक सहा आंतरिक संपत्ती: शम, दम, उपरती, तितिक्षा, श्रद्धा, समाधान." },
        new() { Id=27, Sanskrit="त्रिपुटी", Marathi="त्रिपुटी", English="Triputi", Category="Core Concepts",
                Definition="The triad of knower (Jnata), known (Jneya), and the act of knowing (Jnana) — or perceiver, perceived, and perception. Dissolved in Nirvikalpa Samadhi.",
                DefinitionMarathi="जाणणारा, जाणले जाणारे आणि जाणण्याची क्रिया — ही त्रिपुटी निर्विकल्प समाधीत विलीन होते." },
        new() { Id=28, Sanskrit="कोश", Marathi="कोश", English="Kosha (Sheath)", Category="Three Bodies",
                Definition="The five sheaths that appear to cover the Self: Annamaya (physical), Pranamaya (vital), Manomaya (mental), Vijnanamaya (intellectual), Anandamaya (bliss).",
                DefinitionMarathi="आत्म्याला झाकणारे पाच कोश: अन्नमय, प्राणमय, मनोमय, विज्ञानमय, आनंदमय." },
    };

    // ─── BOOK SECTIONS ────────────────────────────────────────────────────────

    private static readonly List<BookSection> Sections = new()
    {
        new() { Id=1, TitleMarathi="टीकाकारकृत मंगलाचरणम्", TitleEnglish="Auspicious Opening Verse",
                Category="Introduction", PageNumber=23,
                SummaryMarathi="टीकाकार श्रीरामसद्गुरूला वंदन करतात. 'परम शांती (निर्विकल्पवृत्ती) आहे स्वरूप जिचे अशा सीतेशी संयुक्त असणारा, कामक्रोधादि राक्षसांचा शत्रू, संसाररूप समुद्रावर तत्त्वबोधरूप सेतू बांधणारा अशा श्रीरामसद्गुरूला मी वंदन करतो.'",
                Summary="The commentator salutes Shri Rama-Sadguru as the bridge across the ocean of Samsara, destroyer of the demons of desire and anger, embraced by Sita of supreme peace.",
                Shloka="वन्दे श्रीमद्रामंसद्गुरुमतिशान्तिसीतयाऽऽश्लिष्टम्। कामादिराक्षसारिं भवजलधौत्त्वबाधसेतुकर्म्॥",
                ShlokaTranslation="I salute Shri Rama-Sadguru, embraced by Sita of supreme peace, destroyer of the demons of desire, the bridge across the ocean of worldly existence.",
                KeyPointsMarathi=new(){"गुरू म्हणजे ब्रह्मच आहे","शांती हेच आत्म्याचे स्वरूप","संसार म्हणजे समुद्र","ज्ञान हाच सेतू"},
                KeyPoints=new(){"Guru is Brahman made accessible","Peace (Shanti) is the nature of the Self","Samsara is likened to an ocean","Knowledge is the bridge to liberation"} },

        new() { Id=2, TitleMarathi="अनुबंध चतुष्टय", TitleEnglish="Fourfold Prerequisite",
                Category="Introduction", PageNumber=24,
                SummaryMarathi="कोणत्याही शास्त्रग्रंथाच्या अध्ययनापूर्वी चार गोष्टी निश्चित केल्या पाहिजेत: विषय, प्रयोजन, अधिकारी आणि संबंध.",
                Summary="Before any sacred text is studied, four things must be established: subject matter (Vishaya), purpose (Prayojana), qualified student (Adhikari), and the connection between text and purpose (Sambandha).",
                KeyPointsMarathi=new(){"विषय: ब्रह्मविद्या","प्रयोजन: मोक्ष","अधिकारी: विवेकादी साधनसंपन्न मुमुक्षू","संबंध: पंचीकरण थेट आत्मज्ञानाकडे नेते"},
                KeyPoints=new(){"Vishaya: Self-knowledge (Brahma Vidya)","Prayojana: Liberation (Moksha)","Adhikari: The qualified student","Sambandha: Panchikaran leads directly to Self-knowledge"} },

        new() { Id=3, TitleMarathi="अधिकारिलक्षण", TitleEnglish="Qualifications of the Aspirant",
                Category="Adhikari", PageNumber=25,
                SummaryMarathi="आत्मानात्मविवेक, वैराग्य, शमदमादी षट्संपत्ती आणि मोक्षेच्छा अशा चार साधनांनी संपन्न मनुष्य या पंचीकरणाचा अधिकारी आहे असे म्हटले आहे.",
                Summary="Not all are ready for this highest teaching. The four qualifications (Sadhana Chatushtaya) that make a student eligible for Brahma Vidya are defined.",
                KeyPointsMarathi=new(){"विवेक: नित्य-अनित्य भेद","वैराग्य: भोगांची इच्छा नाही","षट्संपत्ती: सहा आंतरिक संपत्ती","मुमुक्षुता: मोक्षाची तीव्र इच्छा"},
                KeyPoints=new(){"Viveka: Discrimination between real and unreal","Vairagya: Dispassion toward impermanent objects","Shat-Sampatti: Sixfold inner wealth","Mumukshatva: Burning desire for liberation"} },

        new() { Id=4, TitleMarathi="शमदमादी षट्संपत्ती", TitleEnglish="The Six Inner Wealths",
                Category="Adhikari", PageNumber=25,
                SummaryMarathi="सहा संपत्ती सांगितल्या आहेत, त्या अशा:- १ शम (सर्व वासनांचा त्याग), २ दम (शब्दादी बाह्य विषयांपासून इंद्रियांचा निग्रह), ३ उपरती (सर्व प्रपंचापासून निवृत्ती), ४ तितिक्षा (शीतोष्णादि द्वंद्व सहन करणे), ५ श्रद्धा (वेदान्तशास्त्रातील वाक्यांवर भक्ती), ६ समाधान (सच्चित्स्वरूप जाणून घेतेवेळी केलेली चित्ताची एकाग्रता).",
                Summary="The six inner disciplines that form Shat-Sampatti — required before the mind can hold the teaching without distortion.",
                KeyPointsMarathi=new(){"शम: मनाचा निग्रह","दम: इंद्रियांचा निग्रह","उपरती: विषयांपासून माघार","तितिक्षा: सहनशीलता","श्रद्धा: गुरू-शास्त्रावर विश्वास","समाधान: चित्ताची एकाग्रता"},
                KeyPoints=new(){"Shama: Control of the mind","Dama: Control of the sense organs","Uparama: Withdrawal from sense enjoyment","Titiksha: Endurance","Shraddha: Faith in Guru and Scripture","Samadhana: One-pointed concentration"} },

        new() { Id=5, TitleMarathi="स्थूल देहाचे वर्णन", TitleEnglish="Description of the Gross Body",
                Category="Three Bodies", PageNumber=89,
                SummaryMarathi="स्थूल देह हा पंचमहाभूतांपासून बनलेला आहे. आकाशाची पाच, वायूची पाच, तेजाची पाच, आपाची पाच आणि पृथ्वीची पाच अशी एकूण पंचवीस तत्त्वे त्यात आहेत.",
                Summary="The gross body (Sthula Deha) is composed of 25 principles drawn from the five gross elements through Panchikaran. See Koshtaka No. 1 for the full table.",
                KeyPointsMarathi=new(){"आकाशाची तत्त्वे: काम, क्रोध, शोक, मोह, भय","वायूची तत्त्वे: चलन, वलन, धावन, प्रसरण, आकुंचन","तेजाची तत्त्वे: क्षुधा, तृषा, आलस्य, निद्रा, कांती","आपाची तत्त्वे: शुक्र, शोणित, लाला, मूत्र, स्वेद","पृथ्वीची तत्त्वे: अस्थी, मांस, त्वचा, नाडी, रोम"},
                KeyPoints=new(){"Akasha principles: Desire, Anger, Grief, Delusion, Fear","Vayu principles: Motion, Bending, Running, Expansion, Contraction","Tejas principles: Hunger, Thirst, Laziness, Sleep, Lustre","Ap principles: Semen, Blood, Saliva, Urine, Sweat","Prithvi principles: Bone, Flesh, Skin, Nerve, Hair"} },

        new() { Id=6, TitleMarathi="सूक्ष्म देहाचे वर्णन", TitleEnglish="Description of the Subtle Body",
                Category="Three Bodies", PageNumber=105,
                SummaryMarathi="सूक्ष्म देह — लिंगदेह — हा पंचज्ञानेंद्रिये, पंचप्राण, मन, बुद्धी, चित्त, अहंकार आणि विषयपंचक असे सतरा घटकांचा बनलेला आहे. मृत्यूनंतर हाच पुढे जातो.",
                Summary="The subtle body (Sukshma Sharira) is 17-fold — it cannot be perceived by the senses, travels at death, and is the seat of all Vasanas and Karma.",
                KeyPointsMarathi=new(){"१७ घटकांचा सूक्ष्म देह","मृत्यूनंतर पुनर्जन्माचे वाहन","वासना येथे साठवतात","मोक्षावेळीच विलीन होतो"},
                KeyPoints=new(){"17 principles form the subtle body","Vehicle of transmigration after death","Vasanas (impressions) stored here","Dissolves only at Moksha"} },

        new() { Id=7, TitleMarathi="अंत:करणपंचकाचे व्याख्यान", TitleEnglish="The Fourfold Inner Instrument",
                Category="Inner Instrument", PageNumber=113,
                SummaryMarathi="अंत:करण म्हणजे मन, बुद्धी, चित्त आणि अहंकार. मन संकल्प-विकल्प करते, बुद्धी निश्चय करते, चित्त चिंतन करते, अहंकार अभिमान धरतो.",
                Summary="The Antahkarana (inner instrument) has four distinct functions: Manas (doubting mind), Buddhi (intellect), Chitta (memory-contemplation), Ahamkara (I-sense).",
                KeyPointsMarathi=new(){"मन: संकल्प-विकल्प — देवता चंद्रमा","बुद्धी: निश्चय — देवता ब्रह्मा","चित्त: चिंतन — देवता नारायण","अहंकार: अभिमान — देवता रुद्र"},
                KeyPoints=new(){"Manas: doubting deliberating mind — presided by Chandra","Buddhi: discriminating intellect — presided by Brahma","Chitta: memory and contemplation — presided by Narayana","Ahamkara: ego-sense — presided by Rudra"} },

        new() { Id=8, TitleMarathi="तत्त्वमसि — महावाक्य", TitleEnglish="Tat Tvam Asi — The Great Declaration",
                Category="Mahavakya", PageNumber=187,
                Shloka="तत्त्वमसि",
                ShlokaTranslation="That Thou Art — You are that very Brahman.",
                SummaryMarathi="'तत्' पदाने ब्रह्म सांगितले, 'त्वम्' पदाने जीव सांगितला. 'असि' पदाने त्यांची अभिन्नता सांगितली. भागत्यागलक्षणेने — जीव व ब्रह्माचे विरोधी अंश सोडून — त्यांची एकता सिद्ध होते.",
                Summary="The Mahavakya from Chandogya Upanishad: the individual self (Tvam/Jiva) is identical with the universal Self (Tat/Brahman). Three methods of implied meaning resolve the apparent contradiction.",
                KeyPointsMarathi=new(){"तत् = निर्गुण ब्रह्म","त्वम् = अंत:करणाचा साक्षी","असि = पूर्ण अभिन्नता","भागत्यागलक्षणा — विरोधी अंश सोडणे"},
                KeyPoints=new(){"Tat = Nirguna Brahman","Tvam = the innermost witness Self","Asi = absolute identity","Bhaga-tyaga method — abandon the contradictory parts"} },

        new() { Id=9, TitleMarathi="तीन प्रकारची लक्षणे", TitleEnglish="Three Types of Implied Meaning",
                Category="Mahavakya", PageNumber=189,
                SummaryMarathi="जहल्लक्षणा, अजहल्लक्षणा आणि जहदजहल्लक्षणा — या तीन पद्धतींनी शब्दांचा वेगळा अर्थ काढता येतो. तत्त्वमसि समजण्यासाठी तिसरी — जहदजहल्लक्षणा — वापरली जाते.",
                Summary="Three methods of implied meaning (Lakshana) resolve the apparent contradiction in Tat Tvam Asi: Jahallakshana, Ajahallakshana, and Jahadajahallakshana.",
                KeyPointsMarathi=new(){"जहल्लक्षणा: मूळ अर्थ सोडणे","अजहल्लक्षणा: मूळ अर्थ कायम ठेवणे","जहदजहल्लक्षणा: विरोधी भाग सोडून उरलेले घेणे","तत्त्वमसीसाठी तिसरी पद्धत वापरतात"},
                KeyPoints=new(){"Jahallakshana: abandon the literal meaning","Ajahallakshana: retain the literal meaning","Jahadajahallakshana: abandon contradictory parts, retain compatible parts","Third method used for Tat Tvam Asi"} },

        new() { Id=10, TitleMarathi="अद्वैत ब्रह्माचे वर्णन", TitleEnglish="Non-Dual Brahman",
                Category="Brahman", PageNumber=181,
                Shloka="सच्चिदानन्दरूपाय सर्वाधाराय शान्तये।",
                ShlokaTranslation="To the one who is Existence-Consciousness-Bliss, the support of all, the embodiment of peace.",
                SummaryMarathi="ब्रह्म सत्-चित्-आनंदरूप आहे. सत् म्हणजे जे कधी नाहीसे होत नाही. चित् म्हणजे जे कधी अंधकारमय होत नाही. आनंद म्हणजे जे सदा परिपूर्ण आहे. हे तीन वेगळे नाहीत — एकच.",
                Summary="Brahman is described as Sat-Chit-Ananda — Pure Existence, Pure Consciousness, Pure Bliss — beyond all attributes, beyond time and space, the only Reality.",
                KeyPointsMarathi=new(){"सत्: जे कधी नाश पावत नाही","चित्: जे कधी अज्ञानाने झाकले जात नाही","आनंद: जे सदा परिपूर्ण आहे","अद्वैत: दुसरे काहीच नाही"},
                KeyPoints=new(){"Sat: Existence that never ceases","Chit: Consciousness that never dims","Ananda: Bliss without cause or object","Non-dual: no second thing exists"} },

        new() { Id=11, TitleMarathi="निर्विकल्प समाधीचे वर्णन", TitleEnglish="Nirvikalpa Samadhi",
                Category="Liberation", PageNumber=216,
                SummaryMarathi="निर्विकल्प समाधीत सर्व मनोवृत्ती पूर्णपणे थांबतात. जाणणारा, जाणले जाणारे आणि जाणण्याची क्रिया — त्रिपुटी — नाहीशी होते. शुद्ध अखंड चेतना मात्र उरते. हाच ब्रह्माचा साक्षात्कार.",
                Summary="In Nirvikalpa Samadhi all mental modifications completely cease. The triad of knower, known, and knowing dissolves. Pure undivided Consciousness alone remains.",
                KeyPointsMarathi=new(){"सर्व मनोवृत्ती थांबतात","त्रिपुटी नाहीशी होते","शुद्ध अखंड चेतना उरते","हाच ब्रह्मसाक्षात्कार"},
                KeyPoints=new(){"All mental modifications cease","Subject-object distinction dissolved","Pure undivided Consciousness remains","This is direct realization of Brahman"} },

        new() { Id=12, TitleMarathi="साधुसमागमाचे महत्व", TitleEnglish="The Importance of Satsanga",
                Category="Liberation", PageNumber=230,
                SummaryMarathi="साधुसमागमाने अनेक जन्मांच्या वासना एका क्षणात नाहीशा होऊ शकतात. संसाररूप समुद्र पार करण्यासाठी हीच सर्वोत्तम नौका आहे.",
                Summary="Even a moment of true Satsanga can dissolve years of accumulated Vasanas. The text extols this as the highest of all spiritual practices.",
                KeyPointsMarathi=new(){"सत्संग म्हणजे सत्याचा सहवास","गुरूचे नुसते अस्तित्व ज्ञान देते","सत्संगाने वासना नाश पावतात","संसाररूप समुद्र पार करण्याची नौका"},
                KeyPoints=new(){"Satsanga = being in company of Truth","Guru's mere presence transmits Jnana","Satsanga dissolves Vasanas","The boat across the ocean of Samsara"} },
    };
}
