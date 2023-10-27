# AvatradeAssignment
AvaTrade Home Assignment


#**Solution Architecture 1**
##**Components**:


  Trading News Consumer: This component is responsible for consuming trading news from the Polygon.io API every hour. It then enriches the data with any available and additional information, such as ticker chart data.
  Trading News Store: This component is responsible for storing the enriched trading news data. It can use any storage solution, such as a relational database or a NoSQL database.
  Trading News API: This component provides a web API that allows clients to access the trading news data. It implements the following endpoints:
      Get all news
      Get all news from today – {n} days
      Get all news per instrument name including news limit (default limit = 10)
      Get all news that contains {text}
      Allow customers to subscribe
      Get the latest news (top latest 5 different instruments) for a conversion tool


##**User Stories**:
  As a customer, I want to be able to see all of the trading news for today.
  As a customer, I want to be able to see all of the trading news for a specific instrument.
  As a customer, I want to be able to search for trading news that contains a specific keyword.
  As a customer, I want to be able to subscribe to trading news for a specific instrument.
  As a customer, I want to see the latest trading news for the top 5 instruments.


I recommend Solution 1 because it is simpler and more straightforward to implement. It is also a good solution for small to medium-sized businesses. 
For larger businesses, Solution 2 may be a better option because it is more modular and reusable.

#**Solution Architecture 2**
##**Components**:
  Messaging Queue: This component is responsible for mediating communication between the different components of the system.
  Trading News Consumer: This component is responsible for consuming trading news from the Polygon.io API and publishing it to the messaging queue.
  Trading News Enricher: This component is responsible for enriching the trading news data with any additional information that is available, such as ticker chart data. 
      It subscribes to the messaging queue and consumes the trading news data that is published by the Trading News Consumer. 
      It then enriches the data and publishes it to the messaging queue.
  Trading News Store: This component is responsible for storing the enriched trading news data. It subscribes to the messaging queue and consumes the trading news data that is published by the Trading News Enricher. 
      It then stores the data in the database.
  Trading News API: This component provides a web API that allows clients to access the trading news data. It subscribes to the messaging queue and consumes the trading news data that is published by the Trading News Enricher. 
      It then provides the data to clients through the web API.


##**User Stories**:
  As a customer, I want to be able to see all of the trading news for today.
  As a customer, I want to be able to see all of the trading news for a specific instrument.
  As a customer, I want to be able to search for trading news that contains a specific keyword.
  As a customer, I want to be able to subscribe to trading news for a specific instrument.
  As a customer, I want to see the latest trading news for the top 5 instruments.


I recommend Solution 2 because it is more modular and reusable. This makes it easier to add new features and functionality to the system in the future. It is also a good solution for large businesses that need to scale their system.


##**Comparison**:
Solution 1 -  Pros:	Simple and straightforward	
              Cons: Requires more code to implement the Trading News Store and Trading News API

Solution 2	- Pros: More modular and reusable	
              Cons: More complex to implement and manage



#Solution Architecture 3
The following solution architecture is an improvement over the previous two architectures because it is more scalable and maintainable.

##**Components**:
  API Gateway: The API Gateway is a single point of entry for all client requests. It routes requests to the appropriate microservices and handles authentication and authorization.
  Trading News Consumer Microservice: This microservice is responsible for consuming trading news from the Polygon.io API and publishing it to the Kafka messaging queue.
  Trading News Enricher Microservice: This microservice is responsible for enriching the trading news data with any additional information that is available, such as ticker chart data. 
    It subscribes to the Kafka messaging queue and consumes the trading news data that is published by the Trading News Consumer Microservice. It then enriches the data and publishes it to the Kafka messaging queue.
  Trading News Store Microservice: This microservice is responsible for storing enriched trading news data. It subscribes to the Kafka messaging queue and consumes the trading news data that is published by the Trading News Enricher Microservice. 
    It then stores the data in the database.
  Trading News API Microservice: This microservice provides a web API that allows clients to access the trading news data. It subscribes to the Kafka messaging queue and consumes the trading news data that is published by the Trading News Enricher Microservice. 
    It then provides the data to clients through the web API.
  Authorization Microservice: This microservice is responsible for authenticating and authorizing users. It provides a token-based authentication system.
  Subscription Microservice: This microservice is responsible for managing user subscriptions to trading news. It allows users to subscribe to news for specific instruments and to receive notifications when new news is published.

##**Scalability**:
  This solution architecture is scalable because each microservice can be scaled independently. 
  For example, if the Trading News API Microservice is experiencing high traffic, it can be scaled horizontally by adding more instances of the microservice.

##**Maintainability**:
  This solution architecture is maintainable because each microservice is responsible for a specific task. This makes it easier to understand and debug the system. Additionally, 
    each microservice can be developed and deployed independently, which makes it easier to make changes to the system without affecting the other microservices.

##**User Stories**:
  As an authorized user, I want to be able to see all of the trading news for today.
  As an authorized user, I want to be able to see all of the trading news for a specific instrument.
  As an authorized user, I want to be able to search for trading news that contains a specific keyword.
  As an authorized user, I want to be able to subscribe to trading news for a specific instrument.
  As an authorized user, I want to receive notifications when new news is published for the instruments that I am subscribed to.


How to Improve the Solution Further:
  The solution architecture can be further improved by using a distributed caching system, such as Redis. The distributed caching system can be used to cache frequently accessed data, such as the latest trading news for the top 5 instruments. 
    This can improve the performance of the system by reducing the number of database queries.
  Additionally, the solution architecture can be further improved by using a load balancer to distribute traffic between the different microservices. This can improve the reliability of the system by ensuring that no single microservice is overloaded.
