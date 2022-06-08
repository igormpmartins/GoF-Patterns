using Singleton;

using (Logger logger = Logger.Instance)
{

    logger.Log(string.Format("Logging started at {0}", DateTime.Now));
    logger.Log("Hello World!");
    logger.Log(string.Format("Logging ended at {0}", DateTime.Now));
}