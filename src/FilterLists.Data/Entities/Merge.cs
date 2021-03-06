﻿namespace FilterLists.Data.Entities
{
    public class Merge : BaseEntity
    {
        public int MergeFilterListId { get; set; }
        public FilterList MergeFilterList { get; set; }

        public int UpstreamFilterListId { get; set; }
        public FilterList UpstreamFilterList { get; set; }
    }
}