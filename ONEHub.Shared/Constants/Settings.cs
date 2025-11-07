namespace ONEHub.Shared.Constants;

public static class Settings
{
    public const string QueueIdentify = "ONEHub.user.signup";
    public const string CacheRedisQueueName = "ONEHub.LandingPage.SignUp";
    public const string TurnOnErrorQueueConsumer = "ONEHub.LandingPage.TurnOnErrorQueueConsumer";

    public const string MainExchangeName = $"{QueueIdentify}.exchange";
    public const string RetryExchangeName = $"{QueueIdentify}.retry.exchange";
    public const string ErrorExchangeName = $"{QueueIdentify}.error.exchange";
    public const string MainQueueName = $"{QueueIdentify}.queue";
    public const string RetryQueueName = $"{QueueIdentify}.retry.queue";
    public const string ErrorQueueName = $"{QueueIdentify}.error.queue";
    public const string RoutingKey = $"{QueueIdentify}.routing";


    public const string UseProxyWithForwardHeaders = "UseProxyWithForwardHeaders";
    public const string UseProxy = "UseProxy";
}
