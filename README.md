# Redington.ProbabilityManagement
## Description
The probabilities Calculator Tool.

Although this is a artifcially small project but I've created it using Clean Code Architectural style (Domain, Application, Infrastructure Layer etc), CQRS/ Mediator design pattern to demonstrate the skills as a part of this exercise.  
The calculated probability is also written to the text file under folder "Redington.ProbabilityManagement.Server" 

## Getting Started

### Dependencies

* .Net 8, C#, MediatR, Fluent Assertions

### Installing

* If prompt please install the relevent packages i.e (MediatR, Fluent Assertions)

### Executing program

* Redington.ProbabilityManagement.Server should be setup as a startup project and contains API controller
* Swagger endpoint is also available to play and interect with the web api (https://localhost:7211/swagger/index.html)
* you can follow ProbabilityCalculatorController to start and go through the code further.
```
 [Route("api/[controller]")]
 [ApiController]
 public class ProbabilityCalculatorController(IMediator mediator) : ControllerBase
 {        
```

## Help

If you experience any issue running the project please let me know.

## Swagger 
![image](https://github.com/user-attachments/assets/fe3bbb1b-7e1e-4504-8f67-5aa245e715ce)



## Authors

Nauman Asif
