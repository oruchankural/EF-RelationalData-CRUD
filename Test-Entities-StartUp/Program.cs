using System;
using Test_Entities.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Test_Entities.Business.Concrete;
using Test_Entities.EF;
using Test_Entities.GenericRepository;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Test_Entities_StartUp
{
    public class Program
    {

       

        public static void Main(string[] args)
        {

            // Silme , Listemele (relation), Update , Create


          
            //Tüm context yüklendiği için tüm datalar beraberinde gelir !
            using var c = new Context();

            //Ticket Chat Ekledin , TicketId ile
            /*TicketChat ticketChat = new TicketChat
            {

                Message = "Test-2",
                Sender = c.Users.Find(1),
                Receiver = c.Users.Find(1),
                TicketId = 1,
                Time = DateTime.Now
            
            };
            c.TicketChats.Add(ticketChat);
            c.SaveChanges();*/

            //Ticket Chat Attachment Ekledin , TicketChatId ile
            /*TicketChatAttachment ticketChatAttachment = new TicketChatAttachment
            {
                TicketChatId = 2,
                TicketChatAttachmentName = "Test-Document",
                TicketChatAttachmentPath = "/Documents/test.pdf"
            };
            c.TicketChatAttachments.Add(ticketChatAttachment);
            c.SaveChanges();*/

            //Ticket Relations
            List<string> entities = new List<string>{
                "Process",
                "Survey.AnswerQuestion.Question",
                "Receiver.Firm",
                "Sender.Firm",
                "Survey.AnswerQuestion.Answer",
                "TicketNotes.Sender",
                "TicketChats.TicketChatAttachments",
                "TicketChats.Sender",
                "TicketChats.Receiver",
                "TicketAttachments"
            };

            /*Ticket ticket = new Ticket
            {
                ReceiverId = 1,
                SenderId = 1,
                TicketAttachments = new List<TicketAttachment> { new TicketAttachment { TicketAttachmentName = "Test", TicketAttachmentPath = "/path" } },
                TicketCode = "FEY-2",
                Process = c.Processes.Find(1)
                

            };
            c.Tickets.Add(ticket);
            c.SaveChanges();*/

            var ticket = c.Tickets.Find(2);
            c.Tickets.Remove(ticket);
            c.SaveChangesAsync();


            /*notify.TicketAttachments = new List<TicketAttachment> { new TicketAttachment { TicketAttachmentName = "Test", TicketAttachmentPath = "/path" } };
            c.Tickets.Update(notify);
            c.SaveChanges();*/




            /*Notify notify = new Notify()
            {
                TicketId = ticket.TicketId,
                Message = "Test 2. mesaıj",
                Showed = false,
                Sounded = false,
                Time = DateTime.Now,
                UserId = ticket.Sender.UserId
             
            };

            c.Notifies.Add(notify);
            c.SaveChanges();*/

            /*TicketNote ticketNote = new TicketNote
            {
                Sender = c.Users.Find(1),
                Date = DateTime.Now,
                Details = "Test notu",
                TicketId = 1
            };
            c.TicketNotes.Add(ticketNote);
            c.SaveChanges();*/

            // TicketNote eklerken TicketId ' yolluyorsun
            /*TicketNote ticketNote = new TicketNote
            {
                TicketId = 1,
                Sender = c.Users.Find(2),
                Date = DateTime.Now,
                Details = "<p>Test2</p>"
            };
            c.TicketNotes.Add(ticketNote);
            c.SaveChanges();*/


            /*var ticket = c.Tickets.Find(1);
            c.Tickets.Remove(ticket);
            c.SaveChanges();*/


            //Ticket ticket = new Ticket();
            //ticket.TicketCode = "FEY-1";
            //c.Tickets.Add(ticket);


            /*var ticketFounded = c.Tickets.Find(2);
            ticketFounded.Survey = new Survey { SurveyId = 1, Message = "Test" };
            c.Tickets.Update(ticketFounded);
            c.SaveChanges();*/


            /*Ticket ticket = new Ticket();
            ticket.TicketCode = "FEY-2";
            ticket.Process = c.Processes.FindAsync(1).Result;
            ticket.Receiver = c.Users.FindAsync(1).Result;
            ticket.Sender = c.Users.FindAsync(2).Result;*/

            /*var updatedTicket = c.Tickets.Find(2);

            List<AnswerQuestion> answerQuestions = new List<AnswerQuestion>(){

                new AnswerQuestion { Answer = c.Answers.Find(1), Question = c.Questions.Find(2) }
            };
        
            Survey survey = new Survey();
            survey.Message = "Test";
            survey.AnswerQuestion = answerQuestions;
            updatedTicket.Survey = survey;

            c.Tickets.Update(updatedTicket);
            c.SaveChanges();*/

            /*List<string> list = new List<string>{
                "Process","Survey.AnswerQuestion.Question","Receiver.Firm","Sender.Firm","Survey.AnswerQuestion.Answer"
            };

            var ticketList = GetTicket(2, list);
            //
         
            Dictionary<string, string> answerQuestion = new Dictionary<string, string>();
            var ticketSurvey = ticketList.Select(x => x.Survey).SingleOrDefault();
            foreach (var item in ticketSurvey.AnswerQuestion ){
                answerQuestion.Add(item.Question.QuestionDescription, item.Answer.AnswerDescription);
            }

            var relatedSurvey = answerQuestion;*/

            /*List<string> list = new List<string>{
                "Survey.AnswerQuestion"
            };
            var ticket = GetTicket(2, list);*/

            /*var ticket = c.Tickets.Find(1);
            c.Tickets.Remove(ticket);
            c.SaveChanges();*/






            //c.RemoveRange(ticket);
            //c.SaveChanges();

            //Ticket ticket = new Ticket();
            //ticket.TicketCode = "FEY-1";
            //ticket.Survey = c.Surveys.FindAsync(1).Result;
            //ticket.Process = c.Processes.FindAsync(2).Result;
            //ticket.Receiver = c.Users.FindAsync(1).Result;
            //ticket.Sender = c.Users.FindAsync(2).Result;
            //c.Tickets.Add(ticket);
            //c.SaveChanges();

            //var fTicket = c.Tickets.ToList();





            /*
             Bütün datayı yüklemiyor çünkü sadece Ticket Sınıfından gidiyorsun
            TicketManager ticketManager = new TicketManager(new EFTicketDAL());
            var ticketAsync = ticketManager.GetByIdAsync(3).Result;*/



            //CreateTicket();


            /*Survey survey = new Survey { Message = "Test" };
            ticket.Survey = survey;
            c.Tickets.Update(ticket);

            List<Answer_Question> answer_Questions = new List<Answer_Question>();
            foreach (var item in c.Questions.ToList())
            {
                answer_Questions.Add(new Answer_Question { Answer = c.Answers.Find(1), Question = item });
            }
            survey.Answer_Question = answer_Questions;
            c.Surveys.Update(survey);
            c.SaveChangesAsync();*/




            /*var range = c.Tickets.Where(x => x.TicketId == 4).Include(y => y.Survey);
            c.RemoveRange(range);
            c.SaveChangesAsync();*/

        }



        public static List<Notify> GetNotify(int id, List<string> entities)
        {
            using (var c = new Context())
            {
                var ticket = c.Notifies.Where(x=>x.NotifyId == id).AsQueryable();
                foreach (var entity in entities)
                {

                    ticket = ticket.Include(entity);
                }


                return ticket.ToList();

            }
        }



        public static List<Ticket> GetTicket(int id,List<string> entities)
        {
            using (var c = new Context())
            {
                var ticket = c.Tickets.Where(x => x.TicketId == id).AsQueryable();
                foreach (var entity in entities)
                {
                    
                    ticket = ticket.Include(entity);
                }


                return ticket.ToList();

            }
        }

        public static void CreateTicket()
        {
            Context c = new Context();

            Ticket ticket = new Ticket
            {
                TicketCode = "FEY-1",
                Process = c.Processes.Find(1),
                Receiver = c.Users.Find(1),
                Sender = c.Users.Find(2)
            };

            c.Tickets.Add(ticket);
            c.SaveChangesAsync();
        }

        public static void CreateSurvey()
        {
            Context c = new Context();


            //var ticket = c.Tickets.Find(4);
            //Survey survey = new Survey { Message = "Test" };
            //ticket.Survey = survey;

            //var process = c.Processes.Where(x => x.ProcessId == 2).SingleOrDefault();
            //var process2 = c.Processes.Where(x => x.ProcessId == 1).SingleOrDefault();

            //ticket.Process = process;

            //c.Update(ticket);


            //Answer answer = new Answer() { AnswerDescription = "Çok İyi" };
            //Answer answer2 = new Answer() { AnswerDescription = " İyi" };

            //Question question = new Question() { QuestionDescription = "Testler iyi mi 2 ?" };
            //Question question2 = new Question() { QuestionDescription = "Sonuçlar iyi mi 2 ?" };

            //c.AddRange(answer, answer2, question, question2);
            //c.SaveChangesAsync();

            /*List<Answer_Question> answer_Questions = new List<Answer_Question>() {
             new Answer_Question { Answer = answer, Question = question },
             new Answer_Question { Answer = answer2, Question = question2 },

            };

            survey.Answer_Question = answer_Questions;
            c.Surveys.Update(survey);
            c.SaveChangesAsync();*/

        }
    }
}
