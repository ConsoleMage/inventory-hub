# inventory-hub

## Introduction

Imagine you are part of a development team tasked with building InventoryHub, an inventory management system for a small business. The application must allow users to view product details from a back-end API. Your goal is to create the integration between the front-end (Blazor) and the back-end (Minimal API).

## Activity 1: Using Microsoft Copilot to Generate and Refine Integration Code

<img width="1936" height="1026" alt="Activity 1" src="https://github.com/user-attachments/assets/a56abdeb-95ae-44f8-aca7-1e713d0955ff" />

(5 pts) Did you create a GitHub repository for your project?

> Yes. You can view it at https://github.com/ConsoleMage/inventory-hub.

(5 pts) Did you generate and refine integration code for front-end and back-end communication?

> Yes. I used Microsoft Copilot to generate API call logic inside the OnInitializedAsync method.

(5 pts) Did you include a reflective summary explaining how Copilot assisted in each step?

> Yes. It was great to have Copilot generate the code for me and wrap it around a `try...catch` block to handle any potential errors that might occur.

## Activity 2: Debugging and Fixing Integration Issues with Copilot

<img width="1936" height="1026" alt="Activity 2" src="https://github.com/user-attachments/assets/75976c57-26be-4828-bf66-3890b24f417f" />

(5 pts) Did you debug and resolve integration issues effectively using Microsoft Copilot?

> Yes. I was testing the API call logic by using relative endpoints instead of using the full URL but it was not able to find the JSON response at that defined endpoint. I ended up using the full URL anyhow.

(5 pts) Did you include a reflective summary explaining how Copilot assisted in each step?

> Yes. I understood that sometimes you may need more control over the deserialization process, hence the need to use `GetAsync` instead of `GetFromJsonAsync<T>`. Copilot assisted me in writing out the code for serializer options to resolve any potential deserialization issues.

## Activity 3: Creating and Managing JSON with Microsoft Copilot

<img width="1936" height="1026" alt="Activity 3" src="https://github.com/user-attachments/assets/fb162dae-b3c0-470c-9e66-4b3e37fccd84" />

(5 pts) Did you create and implement JSON structures for API communication?

> Yes. Copilot recommended to use strongly-typed to meet industry standards, so I did, and accepted its recommendations into my code.

(5 pts) Did you include a reflective summary explaining how Copilot assisted in each step?

> Yes. Copilot was able to quickly generate typed models based on my existing JSON structures in C#. and even suggested improvements to make my JSON structures more efficient and well-structured.

## Activity 4: Optimizing Integration Code for Performance Using Microsoft Copilot

<img width="1936" height="1026" alt="Activity 4" src="https://github.com/user-attachments/assets/5c2ddd07-07af-433f-9626-acae9d5b9be2" />

(5 pts) Did you optimize the integration code for performance using Microsoft Copilot?

> Yes. The API was called only on initial load to prevent redundant requests. In-memory caching was used with a sliding expiration of 5 minutes, which reset on each access to keep the data available as long as it was actively used.

(5 pts) Did you include a reflective summary explaining how Copilot assisted in each step?

> Yes. Even with unfamiliar libraries or NuGet packages, Copilot assisted me in integrating code into my existing project efficiently, with minimal issues. Earlier, I created a separate project containing the `Product` class to reduce code duplication across the client and server. Copilot also guided me through setting up the necessary references.
