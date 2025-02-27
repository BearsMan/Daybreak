﻿using Microsoft.Extensions.Logging;
using System.Core.Extensions;
using System.IO;

namespace Daybreak.Services.Startup.Actions;

public sealed class RenameInstallerAction : StartupActionBase
{
    private const string TemporaryInstallerFileName = "Daybreak.Installer.Temp.exe";
    private const string InstallerFileName = "Daybreak.Installer.exe";

    private readonly ILogger<RenameInstallerAction> logger;

    public RenameInstallerAction(
        ILogger<RenameInstallerAction> logger)
    {
        this.logger = logger.ThrowIfNull();
    }

    public override void ExecuteOnStartup()
    {
        if (File.Exists(TemporaryInstallerFileName))
        {
            this.logger.LogInformation("Detected new installer version. Overwriting old installer with new one");
            File.Copy(TemporaryInstallerFileName, InstallerFileName, true);

            this.logger.LogInformation("Deleting new installer temporary file");
            File.Delete(TemporaryInstallerFileName);
        }
    }
}
