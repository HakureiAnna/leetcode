public class WordDictionary {
      private Node root;

        /** Initialize your data structure here. */

        public WordDictionary()
        {
            root = new Node('\0');
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            addWord(root, word, 0);
        }

        void addWord(Node current, string word, int i)
        {
            var processed = false;
            foreach (var child in current.children)
            {

                // if child matches current char
                if (child.ch == word[i])
                {
                    // if i == wordLen - 1
                    if (i == word.Length - 1)
                    {
                        // mark child as word
                        child.isWord = true;
                        // return
                        return;
                    }
                    // process next char
                    addWord(child, word, i + 1);

                    // mark processed
                    processed = true;
                    break;
                }   
            }

            // if !processed
            if (!processed)
            {
                // add current char to current
                var child = new Node(word[i]);
                current.children.Add(child);

                // if i == wordLen - 1
                if (i == word.Length - 1)
                {
                    // mark newChild as word
                    child.isWord = true;
                    // return
                    return;
                }
                // continue to next char
                addWord(child, word, i + 1);
            }
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return search(root, word, 0);
        }

        private bool search(Node current, string word, int i)
        {
            if (word.Length == 0)
            {
                return false;
            }

            var result = false;
            // if current char is '.'
            if (word[i] == '.')
            {
                // iterate thru each children
                foreach (var child in current.children)
                {
                    // if i == wordLen - 1
                    if (i == word.Length - 1)
                    {
                        result |= child.isWord;
                        if (result)
                        {
                            // return child.isWord
                            return result;
                        }
                    }
                    // OR process each subsequent char                    
                    if (i < word.Length - 1)
                    {
                        result |= search(child, word, i + 1);
                        if (result)
                        {
                            return result;
                        }
                    }
                }
                return false;
            }
            // else
            else
            {
                // iterate over each children
                foreach (var child in current.children)
                {
                    // if match
                    if (word[i] == child.ch)
                    {
                        // if i == wordLen - 1
                        if (i == word.Length - 1)
                        {
                            // return child.isWord
                            return child.isWord;
                        }
                        // process child
                        return search(child, word, i + 1);
                    }
                }
                // return false
                return false;
            }
        }
    }

    class Node
    {
        public List<Node> children;
        public char ch;
        public bool isWord;

        public Node(char ch)
        {
            this.ch = ch;
            children = new List<Node>();
        }
    }
/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */