
// C#-klasser:
var list = new List<string>(); // kjent fra før
var sortedList = new SortedList<string,int>(); // To lister med keys og values holdes sortert
var linkedList = new LinkedList<string>(); // Lenket liste
var dictionary = new Dictionary<string,int>(); // Hash map med keys og values
var sortedDictionary = new SortedDictionary<string,int>(); // Binært søketre med keys og values
var hashSet = new HashSet<string>(); // Hash map med bare verdier
var sortedSet = new SortedSet<string>(); // Binært søketre med bare verdier
var stack = new Stack<string>();
var queue = new Queue<string>();

/*
 * Tre hovedting:
 *  1: lenket liste (node med Next)
 *  2: binært søketre (node med Left og Right)
 *  3: hash map
 */
