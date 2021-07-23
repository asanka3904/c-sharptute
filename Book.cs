using System;



namespace my
{
    

    class Book{

        public string  title;
        public int pages;
        private string author;

        public Book(String title,int page){
          this.title=title;
          this.pages=page;
        }


        public string displaytitle(){
            if(this.title==""){
                return "add title"
            }
            return this.title;
        }


        public int author{
           get {
               return author;
           }
           set {
                author=value;
           }
        }
    }



}