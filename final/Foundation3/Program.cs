using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Pedro Garcia y Francisco Pachecho", "Portoviejo", "Manabi", "1990-365", "Ecuador");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the Portoviejo Stake.", "June 9, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Pozo", 400);

        
            Console.WriteLine("===========================================================================");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("220 E 116", "Manhattan", "NYC", "2700-144", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Laura and Kevin", "Laura and Kevin's wedding ceremony and reception", "November 15, 2024", "3:00 pm - 12:00am", $"{receptionAddress}", "Reception", "dancar@gmail.com");
        
        Console.WriteLine("================================================================================");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("1ro de enero", "Portoviejo", "Manabi", "43017", "Ecuador");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Picklebaññ", "Play pickleball at the park for all youth.", "June 4, 2024", "5:00 pm", $"{outdoorAddress}", "Outdoor", "Night");
    
        Console.WriteLine("================================================================================");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("=================================================================================");
        
    }
}