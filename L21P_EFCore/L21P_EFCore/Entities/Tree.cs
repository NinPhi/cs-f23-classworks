namespace L21P_EFCore.Entities;

        public class Tree
        {
            public TreeType Type { get; set; }
            public int BranchCount { get; set; }
            public double Height { get; set; }
        }

        public enum TreeType
        {
            Oak = 1,
            Birch = 2,
            Pine = 3,
        }

