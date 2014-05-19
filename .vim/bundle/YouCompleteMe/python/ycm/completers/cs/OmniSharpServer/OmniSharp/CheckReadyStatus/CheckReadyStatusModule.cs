using Nancy;
using OmniSharp.Solution;

namespace OmniSharp.CheckReadyStatus
{
    public class CheckReadyStatusModule : NancyModule
    {
        public CheckReadyStatusModule(ISolution solution)
        {
            Post["/checkreadystatus"] = x =>
                {
                    return Response.AsJson(solution.Loaded);
                };
        }
    }
}
