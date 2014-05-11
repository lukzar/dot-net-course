using System;
using System.Collections;
using System.Collections.Generic;

namespace DrzewoBinarne
{
    class BinaryTreeNode<T> : IEnumerable<T>
    {
        #region Properties

        public T Value
        {
            get;
            protected set;
        }

        public BinaryTreeNode<T> Left
        {
            get;
            protected set;
        }

        public BinaryTreeNode<T> Right
        {
            get;
            protected set;
        }

        #endregion

        #region Constructors

        public BinaryTreeNode(BinaryTreeNode<T> Left, T Value, BinaryTreeNode<T> Right)
        {
            this.Left = Left;
            this.Value = Value;
            this.Right = Right;
        }

        public BinaryTreeNode(T Value) : this(null, Value, null) { }

        #endregion

        #region DFS Enumerators

        class TreeDFSEnumerator : IEnumerator<T>
        {
            private Queue<T> Data = null;

            private BinaryTreeNode<T> Root;

            private T CurrentValue;

            public TreeDFSEnumerator(BinaryTreeNode<T> tree)
            {
                Root = tree;
            }

            private void Traverse(BinaryTreeNode<T> tree)
            {
                Data.Enqueue(tree.Value);

                if (tree.Left != null)
                {
                    Traverse(tree.Left);
                }

                if (tree.Right != null)
                {
                    Traverse(tree.Right);
                }
            }

            #region IEnumerator members

            public T Current
            {
                get
                {
                    if (Data == null)
                    {
                        throw new InvalidOperationException("Call MoveNext method before calling Current property.");
                    }

                    return CurrentValue;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (Data == null)
                {
                    Data = new Queue<T>();

                    Traverse(Root);
                }

                if (Data.Count > 0)
                {
                    CurrentValue = this.Data.Dequeue();

                    return true;
                }

                return false;
            }

            public void Reset()
            {
                Data = null;

                Traverse(Root);
            }

            #endregion
        }

        public IEnumerator<T> GetTraditionalDFSEnumerator()
        {
            return new TreeDFSEnumerator(this);
        }

        public IEnumerator<T> GetDFSEnumerator()
        {
            yield return Value;

            if (Left != null)
            {
                foreach (var child in Left)
                {
                    yield return child;
                }
            }

            if (Right != null)
            {
                foreach (var child in Right)
                {
                    yield return child;
                }
            }
        }

        #endregion

        #region BFS Enumerators

        class TreeBFSEnumerator : IEnumerator<T>
        {
            private Queue<T> Data = null;

            private BinaryTreeNode<T> Root;

            private T CurrentValue;

            public TreeBFSEnumerator(BinaryTreeNode<T> tree)
            {
                Root = tree;
            }

            private void Traverse(BinaryTreeNode<T> tree)
            {
                Queue<BinaryTreeNode<T>> tmp = new Queue<BinaryTreeNode<T>>();

                tmp.Enqueue(tree);

                while (tmp.Count > 0)
                {
                    BinaryTreeNode<T> n = tmp.Dequeue();

                    Data.Enqueue(n.Value);

                    if (n.Left != null)
                    {
                        tmp.Enqueue(n.Left);
                    }

                    if (n.Right != null)
                    {
                        tmp.Enqueue(n.Right);
                    }
                }
            }

            #region IEnumerator members

            public T Current
            {
                get
                {
                    if (Data == null)
                    {
                        throw new InvalidOperationException("Call MoveNext method before calling Current property.");
                    }

                    return CurrentValue;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose() { }

            public bool MoveNext()
            {
                if (Data == null)
                {
                    Data = new Queue<T>();

                    Traverse(Root);
                }

                if (Data.Count > 0)
                {
                    CurrentValue = this.Data.Dequeue();

                    return true;
                }

                return false;
            }

            public void Reset()
            {
                Data = null;

                Traverse(Root);
            }

            #endregion
        }

        public IEnumerator<T> GetTraditionalBFSEnumerator()
        {
            return new TreeBFSEnumerator(this);
        }

        public IEnumerator<T> GetBFSEnumerator()
        {
            Queue<BinaryTreeNode<T>> q = new Queue<BinaryTreeNode<T>>();

            q.Enqueue(this);

            while (q.Count > 0)
            {
                BinaryTreeNode<T> n = q.Dequeue();

                yield return n.Value;

                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }

                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
            }
        }

        #endregion

        #region IEnumerable<T> members

        public IEnumerator<T> GetEnumerator()
        {
            // return GetTraditionalBFSEnumerator();
            return GetBFSEnumerator();
            // return GetTraditionalDFSEnumerator();
            // return GetDFSEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
