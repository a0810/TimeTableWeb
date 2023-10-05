namespace TimeTable;

/// <summary>
/// This class is for code that will assist functionality within the application 
/// </summary>
public class Code
{
    /// <summary>
    /// calling this method will create a new GUID and convert it into a string so that i can be used as a unique identifier 
    /// </summary>
    /// <returns>a string GUID</returns>
   public string NewID()
    {
        return Guid.NewGuid().ToString();
    }
}