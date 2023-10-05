using TimeTable.Models;

namespace TimeTable;

/// <summary>
/// This class is for code that will assist functionality within the application 
/// </summary>
public class Code
{


    /// <summary>
    /// calling this method will search all possible fields and return a list of all matching results.   
    /// </summary>
    /// <param name="lectures">pass though the oringal array of lectures</param>
    /// <param name="searchTerm">the term that is being searched by</param>
    /// <returns>a list of results</returns>
    public Lecture[]? SearchLectures(Lecture[] lectures, string searchTerm)
    {
        Lecture[] result = new Lecture[]{};

        result = lectures.Where(x =>
            x.courseName.Contains(searchTerm)  ||
            x.moduleName.Contains(searchTerm) ||
            x.lecturerName.Contains(searchTerm) ||
            x.roomNumber.ToString().Contains(searchTerm)||
            x.moduleCode.Contains(searchTerm)).ToArray();
        
        return result;
    }
    

    /// <summary>
    /// calling this method will create a new GUID and convert it into a string so that i can be used as a unique identifier 
    /// </summary>
    /// <returns>a string GUID</returns>
   public string NewID()
    {
        return Guid.NewGuid().ToString();
    }

}