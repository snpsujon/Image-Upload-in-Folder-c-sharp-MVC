       public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Image image)
        {
            if (ModelState.IsValid)
            {
        	// This has come both from view and it has been added in Class in Model

                string fileName = Path.GetFileNameWithoutExtension(image.ImageFile.FileName);
                string extension = Path.GetExtension(image.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                image.ImagePath = "~/Image/" + fileName;  //Where Want to Save
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName); //file name Formate
                image.ImageFile.SaveAs(fileName);

                using (ImageUploadDbEntities db = new ImageUploadDbEntities())
                {
                    db.Images.Add(image);
                    db.SaveChanges();
                }

                ModelState.Clear();
                return RedirectToAction("Index");
            }

            return View(image);
        }
