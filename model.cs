namespace ImageUpload.Models
{
    using System;
    using System.Collections.Generic; // Need to add this line
    using System.ComponentModel;
    using System.Web; // Need to add this line


//See the image to understand better



    public partial class Image
    {
        public int ImageID { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]  //need to add this  line
        public string ImagePath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }  //nedd to add this line
    }
}
