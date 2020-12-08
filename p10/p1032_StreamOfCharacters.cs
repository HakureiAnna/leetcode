
    public class StreamChecker
    {
        Trie words;
        Queue<Node> plausibles;

        public StreamChecker(string[] words)
        {
            this.words = new Trie(words);
            plausibles = new Queue<Node>();
        }

        public bool Query(char letter)
        {
            var size = plausibles.Count;
            
            Node node = words.Find(letter);
            var found = false;
            if (node != null)
            {
                if (node.isLeaf)
                    found = true;
                plausibles.Enqueue(node);
            }
            while (size > 0)
            {
                node = plausibles.Dequeue().FindChild(letter);
                if (node != null)
                {
                    if (node.isLeaf)
                        found = true;
                    plausibles.Enqueue(node);
                }
                size--;
            }

            return found;
        }
    }
    
    class Node
    {
        public bool isLeaf;
        public Node[] children;

        public Node()
        {
            children = new Node[26];
        }

        public Node FindChild(char ch)
        {
            return children[ch - 'a'];
        }
    }

    class Trie
    {
        public Node root;

        public Trie(string[] words)
        {
            root = new Node();
            foreach (var word in words)
            {
                Insert(root, word, 0);
            }
        }

        private void Insert(Node node, string word, int i)
        {
            var id = word[i] - 'a';
            if (node.children[id] == null)
            {
                node.children[id] = new Node();
            }
            if (i + 1 == word.Length)
                node.children[id].isLeaf = true;
            else
                Insert(node.children[id], word, i + 1);
        }

        public Node Find(char ch)
        {
            return root.children[ch - 'a'];
        }
    }