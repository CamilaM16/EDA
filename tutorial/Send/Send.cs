using System.Text;
using RabbitMQ.Client;

string _url = "amqps://czwrrpkj:3i29eqAfs_s7XEmXIh9u-NLMokix9gzz@ostrich.lmq.cloudamqp.com/czwrrpkj";

var factory = new ConnectionFactory {  Uri = new Uri(_url) };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.ExchangeDeclare(exchange: "direct_logs", type: ExchangeType.Direct);

var severity = (args.Length > 0) ? args[0] : "info";
var message = (args.Length > 1)
              ? string.Join(" ", args.Skip(1).ToArray())
              : "Hello World!";
var body = Encoding.UTF8.GetBytes(message);
channel.BasicPublish(exchange: "direct_logs",
                     routingKey: severity,
                     basicProperties: null,
                     body: body);
Console.WriteLine($" [x] Sent '{severity}':'{message}'");

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();
