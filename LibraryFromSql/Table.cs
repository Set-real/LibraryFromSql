﻿namespace LibraryFromSql
{
    public class Table
    {
        public Table() => Fields = new List<string>();

        public string Name { get; set; }

        public List<string> Fields { get; set; }

        public string ImportantField { get; set; }

    }
}
