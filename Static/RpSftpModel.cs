namespace GM.Model.Static
{
    public class RpSftpModel
    {
        public string Enable { get; set; }

        public string RemoteServerName { get; set; }

        public string RemoteUserName { get; set; }

        public string RemotePassword { get; set; }

        public string RemotePort { get; set; }

        public string RemoteSshHostKeyFingerprint { get; set; }

        public string RemoteSshPrivateKeyPath { get; set; }

        public string RemoteServerPath { get; set; }

        public string RemoteServerPathArchive { get; set; }

        public string RemoteMoveFile { get; set; }

        public int NoOfFailRetry { get; set; }

    }
}
