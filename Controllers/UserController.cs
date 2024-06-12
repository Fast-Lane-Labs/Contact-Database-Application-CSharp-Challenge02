using ContactApplication.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ContactApplication.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User> 
        { 
            new User 
            {
                Id = 1,
                Name = "John Doe",
                Email = "John.Doe@fastlane-israel.com"
            } 
        };
        // GET: User
        public ActionResult Index()
        {
     
            return View(userlist);
        }
 
 
        public ActionResult Details(int id)
        {
            // Implement the details method here

        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            //Implement the Create method here
   

        }
 
      // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Implement the Create method (POST) here

        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.
        }
 
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a NotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.
        
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Implement the Delete method here

        }
 
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            // Implement the Delete method (POST) here

        }
    }
}
