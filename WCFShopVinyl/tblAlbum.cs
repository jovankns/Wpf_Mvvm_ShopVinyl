//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFShopVinyl
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAlbum
    {
        public tblAlbum()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }
    
        public int AlbumID { get; set; }
        public Nullable<int> GenreID { get; set; }
        public Nullable<int> ArtistID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public Nullable<int> Storage { get; set; }
    
        public virtual tblArtist tblArtist { get; set; }
        public virtual tblGenre tblGenre { get; set; }
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
