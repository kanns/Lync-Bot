using System;
using System.Threading.Tasks;
using BestMatchDialog;
using Microsoft.Bot.Builder.Dialogs;

namespace LyncBot.Core.Dialogs
{
    [Serializable]
    public class HRPolicyDialog : IDialog<string>
    {
        public Task StartAsync(IDialogContext context)
        {
            throw new NotImplementedException();
        }
    }
}