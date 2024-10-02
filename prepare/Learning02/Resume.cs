public class Resume
{
    //Keeps track of the person's name and a list of their jobs.
    public string _name = "";
        
    public List<Job>_jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}