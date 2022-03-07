using HyperMarket.DB.Models;


namespace HyperMarket.Data.Interfaces
{
    public interface IBlogsService
    {

        void SaveBlog(Blog bl);







        Task<List<Blog>> GetBlogMeta();
        //gets the basic info such as ID,title and small summary, to render while in list view.


        Task<Blog> GetBlogById(int id);
        // to individually get the blog and blog details.




    }
}
