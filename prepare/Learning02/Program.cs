using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engingeer";
        job1._company = "Google";
        job1._startYear = 2027;
        job1._endYear = 2031;

        Job job2 = new Job();

        job2._jobTitle = "Data Engingeer";
        job2._company = "Apple";
        job2._startYear = 2028;
        job2._endYear = 2032;

        Resume resume1 = new Resume();

        resume1._name = "Ivan Cheng";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}