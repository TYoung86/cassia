using System.Diagnostics;
using System.Security.Principal;

namespace Cassia
{
    public interface ITerminalServicesProcess
    {
        int SessionId { get; }
        int ProcessId { get; }
        string ProcessName { get; }
        SecurityIdentifier Sid { get; }
        void Kill();
        void Kill(int exitCode);
        Process GetProcessObject();
    }
}