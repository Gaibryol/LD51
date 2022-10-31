using System.Collections.Generic;

public static class Constants
{
    public enum GameStates { MainMenu = 0, Credits = 1, Settings = 2, Game = 3, Lobby = 4, Room = 5,}

	public enum SubState{Playing = 0,Pause = 1, Help = 2, Hack = 3,Complete = 4, Loading = 5}

    public enum GameType { Default = 0, Timed = 1}

    public enum PlayMode { Single = 0, Multi = 1}

	public enum LetterColors { Blue = 0, Green = 1, Orange = 2, Pink = 3, Purple = 4, Red = 5, Yellow = 6 }

	public static readonly List<string> ThreeLetterList = new List<string>() {"abs", "ace", "act", "add", "age", "aid", "aim", "air", "ale", "all", "alt", "amp", "and", "ant", "any", "ape", "app", "arc", "are", "ark", "arm", "art", "ash", "ask", "ate", "awe", "axe", "bad", "bag", "ban", "bar", "bat", "bay", "bed", "bee", "beg", "bet", "bid", "big", "bin", "bio", "bit", "boo", "bow", "box", "boy", "bra", "bud", "bug", "bum", "bun", "bus", "but", "buy", "bye", "cab", "can", "cap", "car", "cat", "cob", "cod", "con", "cop", "cot", "cow", "cry", "cub", "cue", "cup", "cut", "dab", "dad", "dam", "day", "den", "dew", "did", "die", "dig", "dim", "dip", "doc", "doe", "dog", "dot", "dry", "dub", "due", "dug", "duo", "dye", "ear", "eat", "egg", "ego", "elf", "emu", "end", "era", "eve", "eye", "fan", "far", "fat", "fax", "fed", "fee", "few", "fig", "fin", "fir", "fit", "fix", "flu", "fly", "foe", "fog", "for", "fox", "fry", "fun", "fur", "gag", "gal", "gap", "gas", "gay", "gel", "gem", "get", "gig", "gin", "god", "got", "gum", "gun", "gut", "guy", "gym", "had", "ham", "has", "hat", "hay", "hem", "hen", "her", "hey", "hid", "him", "hip", "his", "hit", "hog", "hop", "hot", "how", "hub", "hue", "hug", "huh", "hum", "hut", "ice", "icy", "ill", "imp", "ink", "inn", "ion", "ivy", "jam", "jar", "jaw", "jay", "jet", "jew", "job", "joe", "jog", "joy", "jug", "key", "kid", "kin", "kit", "lab", "lag", "lap", "law", "lay", "led", "leg", "let", "lid", "lie", "lip", "lit", "log", "lot", "low", "mad", "man", "map", "mat", "max", "may", "men", "met", "mid", "mix", "mob", "mod", "mom", "mop",
	"mud", "mug", "mum", "nab", "nah", "nan", "nap", "nay", "net", "new", "nil", "nip", "nod", "not", "now", "nun", "nut", "oak", "odd", "off", "oil", "old", "one", "orb", "ore", "our", "out", "owe", "owl", "own", "pad", "pal", "pan", "par", "pat", "paw", "pay", "pea", "peg", "pen", "pet", "pew", "pic", "pie", "pig", "pin", "pip", "pit", "pod", "pop", "pot", "pro", "pub", "pup", "put", "rag", "ram", "ran", "rap", "rat", "raw", "ray", "red", "ref", "rep", "rib", "rig", "rim", "rip", "rob", "rod", "rot", "row", "rub", "rug", "rum", "run", "sac", "sad", "sag", "sap", "sat", "saw", "say", "sea", "sec", "see", "set", "sew", "sex", "she", "shy", "sin", "sip", "sir", "sit", "six", "ski", "sky", "sly", "sol", "son", "soy", "spa", "spy", "sub", "sue", "sum", "sun", "tab", "tag", "tan", "tap", "tar", "tax", "tea", "ten", "the", "tie", "tin", "tip", "toe", "ton", "too", "top", "tow", "toy", "try", "tub", "tug", "two", "use", "van", "vat", "vet", "vow", "war", "was", "wax", "way", "web", "wet", "who", "why", "wig", "win", "wit", "won", "yes", "yet", "you", "zip", "zoo"};
	public static readonly List<string> FourLetterList = new List<string>() {"able", "acid", "aged", "also", "area", "army", "away", "baby", "back", "ball", "band", "bank", "base", "bath", "bear", "beat", "been", "beer", "bell", "belt", "best", "bill", "bird", "blow", "blue", "boat", "body", "bomb", "bond", "bone", "book", "boom", "born", "boss", "both", "bowl", "bulk", "burn", "bush", "busy", "call", "calm", "came", "camp", "card", "care", "case", "cash", "cast", "cell", "chat", "chip", "city", "club", "coal", "coat", "code", "cold", "come", "cook", "cool", "cope", "copy", "core", "cost", "crew", "crop", "dark", "data", "date", "dawn", "days", "dead", "deal", "dean", "dear", "debt", "deep", "deny", "desk", "dial", "dick", "diet", "disc", "disk", "does", "done", "door", "dose", "down", "draw", "drew", "drop", "drug", "dual", "duke", "dust", "duty", "each", "earn", "ease", "east", "easy", "edge", "else", "even", "ever", "evil", "exit", "face", "fact", "fail", "fair", "fall", "farm", "fast", "fate", "fear", "feed", "feel", "feet", "fell", "felt", "file", "fill", "film", "find", "fine", "fire", "firm", "fish", "five", "flat", "flow", "food", "foot", "ford", "form", "fort", "four", "free", "from", "fuel", "full", "fund", "gain", "game", "gate", "gave", "gear", "gene", "gift", "girl",
	"give", "glad", "goal", "goes", "gold", "golf", "gone", "good", "gray", "grew", "grey", "grow", "gulf", "hair", "half", "hall", "hand", "hang", "hard", "harm", "hate", "have", "head", "hear", "heat", "held", "hell", "help", "here", "hero", "high", "hill", "hire", "hold", "hole", "holy", "home", "hope", "host", "hour", "huge", "hung", "hunt", "hurt", "idea", "inch", "into", "iron", "item", "jack", "jean", "join", "jump", "jury", "just", "keen", "keep", "kept", "kick", "kill", "kind", "king", "knee", "knew", "know", "lack", "lady", "laid", "lake", "land", "lane", "last", "late", "lead", "left", "less", "life", "lift", "like", "line", "link", "list", "live", "load", "loan", "lock", "logo", "long", "look", "lord", "lose", "loss", "lost", "love", "luck", "made", "mail", "main", "make", "male", "many", "mark", "mass", "matt", "meal", "mean", "meat", "meet", "menu", "mere", "mike", "mile", "milk", "mill", "mind", "mine", "miss", "mode", "mood", "moon", "more", "most", "move", "much", "must", "name", "navy", "near", "neck", "need", "news", "next", "nice", "nick", "nine", "none", "nose", "note", "okay", "once", "only", "open", "oral", "over", "pace", "pack", "page", "paid", "pain", "pair", "palm", "park", "part", "pass", "past", "path", "peak", "pick", "pink", "pipe", "plan", "play", "plot", "plug", "plus", "poll", "pool", "poor", "port", "post", "pull", "pure", "push", "race", "rail", "rain", "rank", "rare", "rate", "read", "real", "rear", "rely", "rent", "rest", "rice", "rich", "ride", "ring", "rise", "risk", "road", "rock", "role", "roll", "roof", "room", "root",
	"rose", "rule", "rush", "ruth", "safe", "said", "sake", "sale", "salt", "same", "sand", "save", "seat", "seed", "seek", "seem", "seen", "self", "sell", "send", "sent", "sept", "ship", "shop", "shot", "show", "shut", "sick", "side", "sign", "site", "size", "skin", "slip", "slow", "snow", "soft", "soil", "sold", "sole", "some", "song", "soon", "sort", "soul", "spot", "star", "stay", "step", "stop", "such", "suit", "sure", "take", "tale", "talk", "tall", "tank", "tape", "task", "team", "tech", "tell", "tend", "term", "test", "text", "than", "that", "them", "then", "they", "thin", "this", "thus", "till", "time", "tiny", "told", "toll", "tone", "took", "tool", "tour", "town", "tree", "trip", "true", "tune", "turn", "twin", "type", "unit", "upon", "used", "user", "vary", "vast", "very", "vice", "view", "vote", "wage", "wait", "wake", "walk", "wall", "want", "ward", "warm", "wash", "wave", "ways", "weak", "wear", "week", "well", "went", "were", "west", "what", "when", "whom", "wide", "wife", "wild", "will", "wind", "wine", "wing", "wire", "wise", "wish", "with", "wood", "word", "wore", "work", "yard", "yeah", "year", "your", "zero", "zone"};
	public static readonly List<string> FiveLetterList = new List<string>() {"anger", "angle", "angry", "apart", "apple", "apply", "arena", "argue", "arise", "array", "aside", "asset", "audio", "audit", "avoid", "award", "aware", "badly", "baker", "bases", "basic", "basis", "beach", "began", "begin", "begun", "being", "below", "bench", "billy", "birth", "black", "blame", "blind", "block", "blood", "board", "boost", "booth", "bound", "brain", "brand", "bread", "break", "breed", "brief", "bring", "broad", "broke", "brown", "build", "built", "buyer", "cable", "calif", "carry", "catch", "cause", "chain", "chair", "chart", "chase", "cheap", "check", "chest", "chief", "child", "china", "chose", "civil", "claim", "class", "clean", "clear", "click", "clock", "close", "coach", "coast", "could", "count", "court", "cover", "craft", "crash", "cream", "crime", "cross", "crowd", "crown", "curve", "cycle", "daily", "dance", "dated", "dealt", "death", "debut", "delay", "depth", "doing", "doubt", "dozen", "draft", "drama", "drawn", "dream", "dress", "drill", "drink", "drive", "drove", "dying", "eager", "early", "earth", "eight", "elite", "empty", "enemy", "enjoy", "enter", "entry", "equal", "error", "event", "every", "exact", "exist", "extra", "faith", "false", "fault", "fiber", "field", "fifth",
	"fifty", "fight", "final", "first", "fixed", "flash", "fleet", "floor", "fluid", "focus", "force", "forth", "forty", "forum", "found", "frame", "frank", "fraud", "fresh", "front", "fruit", "fully", "funny", "giant", "given", "glass", "globe", "going", "grace", "grade", "grand", "grant", "grass", "great", "green", "gross", "group", "grown", "guard", "guess", "guest", "guide", "happy", "harry", "heart", "heavy", "hence", "henry", "horse", "hotel", "house", "human", "ideal", "image", "index", "inner", "input", "issue", "japan", "joint", "judge", "known", "label", "large", "laser", "later", "laugh", "layer", "learn", "lease", "least", "leave", "legal", "level", "light", "limit", "links", "lives", "local", "logic", "loose", "lower", "lucky", "lunch", "lying", "magic", "major", "maker", "march", "maria", "match", "maybe", "mayor", "meant", "media", "metal", "might", "minor", "minus", "mixed", "model", "money", "month", "moral", "motor", "mount", "mouse", "mouth", "movie", "music", "needs", "never", "newly", "night", "noise", "north", "noted", "novel", "nurse", "occur", "ocean", "offer", "often", "order", "other", "ought", "paint", "panel", "paper", "party", "peace", "peter", "phase", "phone", "photo", "piece", "pilot", "pitch", "place", "plain", "plane", "plant", "plate", "point", "pound", "power", "press", "price", "pride", "prime", "print", "prior", "prize", "proof", "proud", "prove", "queen", "quick", "quiet", "quite", "radio", "raise", "range", "rapid", "ratio", "reach", "ready", "refer", "right", "rival", "river", "robin",
	"roger", "roman", "rough", "round", "route", "royal", "rural", "scale", "scene", "scope", "score", "sense", "serve", "seven", "shall", "shape", "share", "sharp", "sheet", "shelf", "shell", "shift", "shirt", "shock", "shoot", "short", "shown", "sight", "since", "sixth", "sixty", "sized", "skill", "sleep", "slide", "small", "smart", "smile", "smith", "smoke", "solid", "solve", "sorry", "sound", "south", "space", "spare", "speak", "speed", "spend", "spent", "split", "spoke", "sport", "staff", "stage", "stake", "stand", "start", "state", "steam", "steel", "stick", "still", "stock", "stone", "stood", "store", "storm", "story", "strip", "stuck", "study", "stuff", "style", "sugar", "suite", "super", "sweet", "table", "taken", "taste", "taxes", "teach", "teeth", "terry", "texas", "thank", "theft", "their", "theme", "there", "these", "thick", "thing", "think", "third", "those", "three", "threw", "throw", "tight", "times", "tired", "title", "today", "topic", "total", "touch", "tough", "tower", "track", "trade", "train", "treat", "trend", "trial", "tried", "tries", "truck", "truly", "trust", "truth", "twice", "under", "undue", "union", "unity", "until", "upper", "upset", "urban", "usage", "usual", "valid", "value", "video", "virus", "visit", "vital", "voice", "waste", "watch", "water", "wheel", "where", "which", "while", "white", "whole", "whose", "woman", "women", "world", "worry", "worse", "worst", "worth", "would", "wound", "write", "wrong", "wrote", "yield", "young", "youth"};
	public static readonly List<string> SixLetterList = new List<string>() {"abroad", "accept", "access", "across", "acting", "action", "active", "actual", "advice", "advise", "affect", "afford", "afraid", "agency", "agenda", "almost", "always", "amount", "animal", "annual", "answer", "anyone", "anyway", "appeal", "appear", "around", "arrive", "artist", "aspect", "assess", "assist", "assume", "attack", "attend", "august", "author", "avenue", "backed", "barely", "battle", "beauty", "became", "become", "before", "behalf", "behind", "belief", "belong", "berlin", "better", "beyond", "bishop", "border", "bottle", "bottom", "bought", "branch", "breath", "bridge", "bright", "broken", "budget", "burden", "bureau", "button", "camera", "cancer", "cannot", "carbon", "career", "castle", "casual", "caught", "center", "centre", "chance", "change", "charge", "choice", "choose", "chosen", "church", "circle", "client", "closed", "closer", "coffee", "column", "combat", "coming", "common", "comply", "copper", "corner", "costly", "county", "couple", "course", "covers", "create", "credit", "crisis", "custom", "damage", "danger", "dealer", "debate", "decade", "decide", "defeat", "defend", "define", "degree", "demand", "depend", "deputy", "desert", "design", "desire", "detail", "detect", "device", "differ", "dinner", "direct", "doctor", "dollar", "domain", "double", "driven", "driver", "during", "easily", "eating", "editor", "effect", "effort", "eighth", "either", "eleven", "emerge", "empire", "employ", "enable", "ending", "energy", "engage", "engine", "enough", "ensure", "entire",
	"entity", "equity", "escape", "estate", "ethnic", "exceed", "except", "excess", "expand", "expect", "expert", "export", "extend", "extent", "fabric", "facing", "factor", "failed", "fairly", "fallen", "family", "famous", "father", "fellow", "female", "figure", "filing", "finger", "finish", "fiscal", "flight", "flying", "follow", "forced", "forest", "forget", "formal", "format", "former", "foster", "fought", "fourth", "french", "friend", "future", "garden", "gather", "gender", "german", "global", "golden", "ground", "growth", "guilty", "handed", "handle", "happen", "hardly", "headed", "health", "height", "hidden", "holder", "honest", "impact", "import", "income", "indeed", "injury", "inside", "intend", "intent", "invest", "island", "itself", "jersey", "joseph", "junior", "killed", "labour", "latest", "latter", "launch", "lawyer", "leader", "league", "leaves", "legacy", "length", "lesson", "letter", "lights", "likely", "linked", "liquid", "listen", "little", "living", "losing", "lucent", "luxury", "mainly", "making", "manage", "manner", "manual", "margin", "marine", "marked", "market", "martin", "master", "matter", "mature", "medium", "member",
	"memory", "mental", "merely", "merger", "method", "middle", "miller", "mining", "minute", "mirror", "mobile", "modern", "modest", "module", "moment", "morris", "mostly", "mother", "motion", "moving", "murder", "museum", "mutual", "myself", "narrow", "nation", "native", "nature", "nearby", "nearly", "nights", "nobody", "normal", "notice", "notion", "number", "object", "obtain", "office", "offset", "online", "option", "orange", "origin", "output", "oxford", "packed", "palace", "parent", "partly", "patent", "people", "period", "permit", "person", "phrase", "picked", "planet", "player", "please", "plenty", "pocket", "police", "policy", "prefer", "pretty", "prince", "prison", "profit", "proper", "proven", "public", "pursue", "raised", "random", "rarely", "rather", "rating", "reader", "really", "reason", "recall", "recent", "record", "reduce", "reform", "regard", "regime", "region", "relate", "relief", "remain", "remote", "remove", "repair", "repeat", "replay", "report", "rescue", "resort", "result", "retail", "retain", "return", "reveal", "review", "reward", "riding", "rising", "robust", "ruling", "safety", "salary", "sample", "saving", "saying", "scheme", "school", "screen", "search", "season", "second", "secret", "sector", "secure", "seeing", "select", "seller", "senior", "series", "server", "settle", "severe", "sexual", "should", "signal", "signed", "silent", "silver", "simple", "simply", "single", "sister", "slight", "smooth", "social", "solely", "sought", "source", "speech", "spirit", "spoken", "spread", "spring", "square", "stable", "status", "steady",
	"stolen", "strain", "stream", "street", "stress", "strict", "strike", "string", "strong", "struck", "studio", "submit", "sudden", "suffer", "summer", "summit", "supply", "surely", "survey", "switch", "symbol", "system", "taking", "talent", "target", "taught", "tenant", "tender", "tennis", "thanks", "theory", "thirty", "though", "threat", "thrown", "ticket", "timely", "timing", "tissue", "toward", "travel", "treaty", "trying", "twelve", "twenty", "unable", "unique", "united", "unless", "unlike", "update", "useful", "valley", "varied", "vendor", "versus", "victim", "vision", "visual", "volume", "walker", "wealth", "weekly", "weight", "window", "winner", "winter", "within", "wonder", "worker", "wright", "writer", "yellow"};
	public static readonly List<string> SevenLetterList = new List<string>() {"ability", "absence", "academy", "account", "accused", "achieve", "acquire", "address", "advance", "adverse", "advised", "adviser", "against", "airline", "airport", "alcohol", "alleged", "already", "analyst", "ancient", "another", "anxiety", "anxious", "anybody", "applied", "arrange", "arrival", "article", "assault", "assumed", "assured", "attempt", "attract", "auction", "average", "backing", "balance", "banking", "barrier", "battery", "bearing", "beating", "because", "bedroom", "believe", "beneath", "benefit", "besides", "between", "billion", "binding", "brother", "brought", "burning", "cabinet", "caliber", "calling", "capable", "capital", "captain", "caption", "capture", "careful", "carrier", "caution", "ceiling", "central", "centric", "century", "certain", "chamber", "channel", "chapter", "charity", "charlie", "charter", "checked", "chicken", "chronic", "circuit", "classes", "classic", "climate", "closing", "closure", "clothes", "collect", "college", "combine", "comfort", "command", "comment", "compact", "company", "compare", "compete", "complex", "concept", "concern", "concert", "conduct", "confirm", "connect", "consent", "consist", "contact", "contain", "content", "contest", "context", "control", "convert", "correct", "council", "counsel", "counter", "country", "crucial", "crystal", "culture", "current", "cutting", "dealing", "decided", "decline", "default", "defence", "deficit", "deliver", "density", "deposit", "desktop", "despite", "destroy", "develop", "devoted", "diamond",
	"digital", "discuss", "disease", "display", "dispute", "distant", "diverse", "divided", "drawing", "driving", "dynamic", "eastern", "economy", "edition", "elderly", "element", "engaged", "enhance", "essence", "evening", "evident", "exactly",
	"examine", "example", "excited", "exclude", "exhibit", "expense", "explain", "explore", "express", "extreme", "factory", "faculty", "failing", "failure", "fashion", "feature", "federal", "feeling", "fiction", "fifteen", "filling", "finance", "finding", "fishing", "fitness", "foreign", "forever", "formula", "fortune", "forward", "founder", "freedom", "further", "gallery", "gateway", "general", "genetic", "genuine", "gigabit", "greater", "hanging", "heading", "healthy", "hearing", "heavily", "helpful", "helping", "herself", "highway", "himself", "history", "holding", "holiday", "housing", "however", "hundred", "husband", "illegal", "illness", "imagine", "imaging", "improve", "include", "initial", "inquiry", "insight", "install", "instant", "instead", "intense", "interim", "involve", "jointly", "journal", "journey", "justice", "justify", "keeping", "killing", "kingdom", "kitchen", "knowing", "landing", "largely", "lasting", "leading", "learned", "leisure", "liberal", "liberty", "library", "license", "limited", "listing", "logical", "loyalty", "machine", "manager", "married", "massive", "maximum", "meaning", "measure", "medical", "meeting", "mention", "message", "million", "mineral", "minimal", "minimum", "missing", "mission", "mistake", "mixture", "monitor", "monthly", "morning", "musical", "mystery", "natural", "neither", "nervous", "network", "neutral", "notable", "nothing", "nowhere", "nuclear", "nursing", "obvious", "offense", "officer", "ongoing", "opening", "operate", "opinion", "optical", "organic", "outcome", "outdoor", "outlook", "outside", "overall",
	"pacific", "package", "painted", "parking", "partial", "partner", "passage", "passing", "passion", "passive", "patient", "pattern", "payable", "payment", "penalty", "pending", "pension", "percent", "perfect", "perform", "perhaps", "phoenix", "picking", "picture", "pioneer", "plastic", "pointed", "popular", "portion", "poverty", "precise",
	"predict", "premier", "premium", "prepare", "present", "prevent", "primary", "printer", "privacy", "private", "problem", "proceed", "process", "produce", "product", "profile", "program", "project", "promise", "promote", "protect", "protein", "protest", "provide", "publish", "purpose", "pushing", "qualify", "quality", "quarter", "radical", "railway", "readily", "reading", "reality", "realize", "receipt", "receive", "recover", "reflect", "regular", "related", "release", "remains", "removal", "removed", "replace", "request", "require", "reserve", "resolve", "respect", "respond", "restore", "retired", "revenue", "reverse", "rollout", "routine", "running", "satisfy", "science", "section", "segment", "serious", "service", "serving", "session", "setting", "seventh", "several", "shortly", "showing", "silence", "silicon", "similar", "sitting", "sixteen", "skilled", "smoking", "society", "somehow", "someone", "speaker", "special", "species", "sponsor", "station", "storage", "strange", "stretch", "student", "studied", "subject", "succeed", "success", "suggest", "summary", "support", "suppose", "supreme", "surface", "surgery", "surplus", "survive", "suspect", "sustain", "teacher", "telecom", "telling", "tension", "theatre", "therapy", "thereby", "thought", "through", "tonight", "totally", "touched", "towards", "traffic", "trouble", "turning", "typical", "uniform", "unknown", "unusual", "upgrade", "upscale", "utility", "variety", "various", "vehicle", "venture", "version", "veteran", "victory", "viewing", "village", "violent", "virtual", "visible", "waiting", "walking",
	"wanting", "warning", "warrant", "wearing", "weather", "webcast", "website", "wedding", "weekend", "welcome", "welfare", "western", "whereby", "whether", "willing", "winning", "without", "witness", "working", "writing", "written"};
	public static readonly List<string> EightLetterList = new List<string>() {"absolute", "abstract", "academic", "accepted", "accident", "accuracy", "accurate", "achieved", "acquired", "activity", "actually", "addition", "adequate", "adjacent", "adjusted", "advanced", "advisory", "advocate", "affected", "aircraft", "alliance", "although", "aluminum", "analysis", "announce", "anything", "anywhere", "apparent", "appendix", "approach", "approval", "argument", "artistic", "assembly", "assuming", "athletic", "attached", "attitude", "attorney", "audience", "autonomy", "aviation", "bachelor", "bacteria", "baseball", "bathroom", "becoming", "benjamin", "birthday", "boundary", "breaking", "breeding", "building", "bulletin", "business", "calendar", "campaign", "capacity", "casualty", "catching", "category", "catholic", "cautious", "cellular", "ceremony", "chairman", "champion", "chemical", "children", "circular", "civilian", "clearing", "clinical", "clothing", "collapse", "colonial", "colorful", "commence", "commerce", "complain", "complete", "composed", "compound", "comprise", "computer", "conclude", "concrete", "conflict", "confused", "congress", "consider", "constant", "consumer", "continue", "contract", "contrary", "contrast", "convince", "corridor", "coverage", "covering", "creation",
	"creative", "criminal", "critical", "crossing", "cultural", "currency", "customer", "database", "daughter", "daylight", "deadline", "deciding", "decision", "decrease", "deferred", "definite", "delicate", "delivery", "describe", "designer", "detailed", "diabetes", "dialogue", "diameter", "directly", "director", "disabled", "disaster", "disclose", "discount", "discover", "disorder", "disposal", "distance", "distinct", "district", "dividend", "division", "doctrine", "document", "domestic", "dominant", "dominate", "doubtful", "dramatic", "dressing", "dropping", "duration", "dynamics", "earnings", "economic", "educated", "efficacy", "eighteen", "election", "electric", "eligible", "emerging", "emphasis", "employee", "endeavor", "engaging", "engineer", "enormous", "entirely", "entrance", "envelope", "equality", "equation", "estimate", "evaluate", "eventual", "everyday", "everyone", "evidence", "exchange", "exciting", "exercise", "explicit", "exposure", "extended", "external", "facility", "familiar", "featured", "feedback", "festival", "finished", "firewall", "flagship", "flexible", "floating", "football", "foothill", "forecast", "foremost", "formerly", "fourteen", "fraction", "frequent", "friendly", "frontier", "function", "generate", "generous", "governor", "graduate", "graphics", "grateful", "guardian", "guidance", "handling", "hardware", "heritage", "highland", "historic", "homeless", "homepage", "hospital", "humanity", "identify", "identity", "ideology", "imperial", "incident", "included", "increase", "indicate", "indirect", "industry", "informal", "informed",
	"inherent", "initiate", "innocent", "inspired", "instance", "integral", "intended", "interact", "interest", "interior", "internal", "interval", "intimate", "intranet", "invasion", "involved", "isolated", "judgment", "judicial", "junction", "keyboard", "landlord", "language", "laughter", "learning", "leverage", "lifetime", "lighting", "likewise", "limiting", "literary", "location", "magazine", "magnetic", "maintain", "majority", "marginal", "marriage", "material", "maturity",
	"maximize", "meantime", "measured", "medicine", "medieval", "memorial", "merchant", "midnight", "military", "minimize", "minister", "ministry", "minority", "mobility", "modeling", "moderate", "momentum", "monetary", "moreover", "mortgage", "mountain", "mounting", "movement", "multiple", "national", "negative", "nineteen", "northern", "notebook", "numerous", "observer", "occasion", "offering", "official", "offshore", "operator", "opponent", "opposite", "optimism", "optional", "ordinary", "organize", "original", "overcome", "overhead", "overseas", "overview", "painting", "parallel", "parental", "patented", "patience", "peaceful", "periodic", "personal", "persuade", "petition", "physical", "pipeline", "platform", "pleasant", "pleasure", "politics", "portable", "portrait", "position", "positive", "possible", "powerful", "practice", "precious", "pregnant", "presence", "preserve", "pressing", "pressure", "previous", "princess", "printing", "priority", "probable", "probably", "producer", "profound", "progress", "property", "proposal", "prospect", "protocol", "provided", "provider", "province", "publicly", "purchase", "pursuant", "quantity", "question", "rational", "reaction", "received", "receiver", "recovery", "regional", "register", "relation", "relative", "relevant", "reliable", "reliance", "religion", "remember", "renowned", "repeated", "reporter", "republic", "required", "research", "reserved", "resident", "resigned", "resource", "response", "restrict", "revision", "rigorous", "romantic", "sampling", "scenario", "schedule", "scrutiny", "seasonal", "secondly",
	"security", "sensible", "sentence", "separate", "sequence", "sergeant", "shipping", "shortage", "shoulder", "simplify", "situated", "slightly", "software", "solution", "somebody", "southern", "speaking", "specific", "spectrum", "sporting", "standard", "standing", "standout", "sterling", "straight", "strategy", "strength", "striking", "struggle", "stunning", "suburban", "suitable", "superior", "supposed", "surgical", "surprise", "survival", "sweeping", "swimming", "symbolic", "sympathy", "syndrome",
	"tactical", "tailored", "takeover", "tangible", "taxation", "taxpayer", "teaching", "tendency", "terminal", "terrible", "thinking", "thirteen", "thorough", "thousand", "together", "tomorrow", "touching", "tracking", "training", "transfer", "traveled", "treasury", "triangle", "tropical", "turnover", "ultimate", "umbrella", "universe", "unlawful", "unlikely", "valuable", "variable", "vertical", "victoria", "violence", "volatile", "warranty", "weakness", "weighted", "whatever", "whenever", "wherever", "wildlife", "wireless", "withdraw", "woodland", "workshop", "yourself"};

	public static Hack0 Hack0= new Hack0(); //  "The first letter of each word is in the correct position|Only the bottom row can be seen";
	public static Hack1 Hack1= new Hack1(); //  "The last letter of each word is in the correct position|Only the bottom row can be seen";
	public static Hack2 Hack2= new Hack2(); //"Decrypt the longest words every 25 seconds|Each word has a chance of having a letter obscured";
	public static Hack3 Hack3= new Hack3(); // "Increase the maximum amount of rows by 2|Only the bottom three rows can be seen";
	public static Hack4 Hack4= new Hack4(); // "Right-click to decrypt a word instantly (Up to 4 uses in a game)|Letters only appear when hovering over the letter tile";
	public static Hack5 Hack5= new Hack5(); //"Letters can be seen as they’re falling down|See 1 less row";
	public static Hack6 Hack6= new Hack6(); // "Right-click instantly drops the falling word|See 1 less row";
	public static Hack7 Hack7= new Hack7(); // "Decrypt a random word every 25 seconds|See 3 less row";
	public static Hack8 Hack8= new Hack8(); //"Decrypt all words (One use per game)|See 2 less lines";


	public const float MaxTime = 10f;
	public const float PointsPerLetter = 200;

	public const float DecryptTime = 25f;

	public const int WarningLimit = 1;

    public const byte GameStartEventCode = 1;
    public const byte PlayerReadyEventCode = 2;

    //H(Destroy a word every 25 seconds - Two words come down every 10 seconds)
    //I(2x the Points - Lose 2 Lines)
}
