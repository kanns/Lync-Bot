using System;
using System.Threading.Tasks;
using BestMatchDialog;
using Microsoft.Bot.Builder.Dialogs;

namespace LyncBot.Core.Dialogs
{
    [Serializable]
    public class HRCommonDialog : BestMatchDialog<string>
    {
        [BestMatch(new string[] { "Hi", "Hi There", "Hello there", "Hey", "Hello", "Hai", "Yo" , "Ya",
            "Hey there", "Greetings", "Good morning", "Good afternoon", "Good evening", "Good day" },
            threshold: 0.5, ignoreCase: true, ignoreNonAlphaNumericCharacters: false)]
        public async Task HandleGreeting(IDialogContext context, string messageText)
        {
            await context.PostAsync("Well hello there. What can I do for you today?");
            context.Wait(MessageReceived);
        }

        [BestMatch(new string[] { "how goes it", "how do", "hows it going", "how are you",
            "how do you feel", "whats up", "sup", "hows things" },
             threshold: 0.5, ignoreCase: true, ignoreNonAlphaNumericCharacters: false)]
        public async Task HandleStatusRequest(IDialogContext context, string messageText)
        {
            await context.PostAsync("I am great.");
            context.Wait(MessageReceived);
        }

        [BestMatch(new string[] { "bye", "bye bye", "got to go",
            "see you later", "laters", "adios" }, threshold: 0.5, ignoreCase: true, ignoreNonAlphaNumericCharacters: false)]
        public async Task HandleGoodbye(IDialogContext context, string messageText)
        {
            await context.PostAsync("Bye. Looking forward to our next awesome conversation already.");
            context.Wait(MessageReceived);
        }

        [BestMatch(new string[] { "thank you,thanks,much appreciated,appreciate,thanks very much,thanking you"},
             threshold: 0.5, ignoreCase: true, ignoreNonAlphaNumericCharacters: false)]
        public async Task HandleThanks(IDialogContext context, string messageText)
        {
            await context.PostAsync("You're welcome.");
            context.Wait(MessageReceived);
        }

        public override async Task NoMatchHandler(IDialogContext context, string messageText)
        {
            await context.PostAsync($"I’m not sure what you want when you say '{messageText}'.");
            context.Wait(MessageReceived);
        }


        [BestMatch(new string[] { "ND", "North D", "North Dokota", "NEPERS", "1", "Nth Dokota" }, ignoreCase: true)]
        public async Task NDPers(IDialogContext context, string messageText)
        {
            // await context.PostAsync("Well hello there. What can I do for you today?");
            context.Done(nameof(NDPers));
            //await context.PostAsync("Bye. Looking forward to our next awesome conversation already.");
            //context.Wait(MessageReceived);
        }

        [BestMatch(new string[] { "Ksas", "Kansas City", "Kansas State", "KPERS", "1", "Kansas Pension" }, ignoreCase: true)]
        public async Task KPERS(IDialogContext context, string messageText)
        {
            context.Done(nameof(KPERS));
            //await context.PostAsync("Bye. Looking forward to our next awesome conversation already.");
            //context.Wait(MessageReceived);
        }



    }
}