# learning-with-VR

CS291A Project Proposal 

Introduction

This project is an attempt to build something in order to demonstrate and encourage social experiences with the help of the technology in a manner that does not let the user become entirely dependent on the technology. In order to do so, we propose to build an interactive AI agent with which we can converse. We plan on working with Unity and using the Oculus Quest 2 to experiment and deploy our project.

For our MVP, we have decided to first tackle the main challenges of the project, i.e. to create an interactive agent in VR using the Oculus Quest 2 and then use NLP based techniques to implement English models such that the user is able to communicate with the agent. We expect significant challenges that may come our way in terms of installations, implementation of existing packages as well as NLP based techniques for our set-up, although we hope to successfully complete this milestone. 

Challenges

Some of the challenges with this include integrating a natural language processing (NLP) model in order for the agent to be able to respond, using a speech recognition platform so the user can interact with the agent, and ensuring the agent moves and behaves in a realistic way. While it may seem these challenges have already been incorporated into gaming and virtual environments, the combination of all these aspects together in real time is very difficult.

The most important part of our project will be to ensure our interatable agent responds in non-trivial or pre-programmed ways. The best and most efficient way to do this is to use OpenAI’s GPT-3 model, which has proven to be able to carry very realistic conversations. In order to use this model, we need to be able to incorporate it into Unity and deploy it on Quest 2. Through our preliminary exploration, we have found that there is a third party package that can use GPT-3 with Unity, but deploying this onto the Quest 2 will be an extremely tedious challenge in itself.

Another important challenge to overcome will be our speech to text integration. While this isn’t as important as integrating an NLP model into our application, this will still be an important piece of our environment. In order to do so, we will use the VoiceSDK feature in the Oculus Integration package in Unity. While this package can be deployed on the Quest 2 relatively easily, the challenge will be to train the voice commands. The SDK has a platform (wit.ai) where the commands can be written out in text, but training this written text to do what we want the application to do will be difficult. For example, we would need the application to recognize a command like “Hey, how are you?” as a greeting, and thus initiate the conversation with the interactive agent.

We also plan to build immersive VR settings in order to improve overall user experience and generate realistic scenarios for the user to interact with different environments for our use case. This includes features such as realistic movements and actions. To do this, we would need to explore packages in Unity that help set up interactive agents and enable movement as not a lot of developers have been successful in doing so. 

Methods

In order to solve some of the challenges above, our preliminary research has led us to a few promising APIs and packages. For voice recognition, the Oculus Integration package in Unity recently released a voice command SDK called VoiceSDK. This package was released in November 2021, so it is not very established and proven yet. However, we were able to deploy a sample proof-of-concept scene that is able to turn speech into text. From this, we can use the (wit.ai) platform to train commands that can initiate and carry conversations with the intractable agent. This package is a very new, but exciting feature that can make our virtual environment closer to reality.

In order to integrate GPT-3 into our application, we will have to be more experimental. Through our exploration, we have found that OpenAI does not have an official Unity package, but there are a couple third party APIs/Unity packages that can be used. We have started exploring that in our tech exploration exercise.

We were able to use one of these APIs to run a sample scene that simply allows the user to type some input, and then outputs GPT-3’s response onto Unity’s console log. This is a very neat proof-of-concept for a desktop version of a game, but integrating this API onto the Quest 2 may prove to be difficult. Nevertheless, once we train our application’s voice commands, use its speech to text system, and then feed the text into the GPT-3 model, GPT-3 should be able to give a coherent response.
