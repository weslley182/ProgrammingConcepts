using DecoratorPatternExample.Interface;
using DecoratorPatternExample.Services;

INotifier notifier = new EmailNotifier();
notifier = new SmsNotifier(notifier);
notifier = new SlackNotifier(notifier);

notifier.Send("System down!");