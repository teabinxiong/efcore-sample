<a name="readme-top"></a>
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT DESC -->
<br />
<div align="center">
  <a href="https://github.com/teabinxiong/efcore-sample">
     <h3 align="center">efcore-sample</h3>
  </a>

  <p align="center">
   EF Core Demo is a GitHub project showcasing the features of Entity Framework Core. It provides practical examples for setting up EF Core, modeling entities, performing data access operations, managing migrations, optimizing performance, testing, and integrating with ASP.NET Core. This resource is ideal for both beginners and experienced developers looking to learn or enhance their skills. Contributions and feedback are welcome to improve the project. Join us in exploring the power of EF Core!
    <br />
    <a href="https://github.com/teabinxiong/efcore-sample"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/teabinxiong/efcore-sample">View Documentation</a>
    ·
    <a href="https://github.com/teabinxiong/efcore-sample/issues">Report Bug</a>
    ·
    <a href="https://github.com/teabinxiong/efcore-sample/issues">Request Feature</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Projects Structure</a></li>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

## About The Project

[![Product Name Screen Shot][product-screenshot]](https://github.com/teabinxiong/efcore-sample)

EF Core Demo is a GitHub project showcasing the features of Entity Framework Core. It provides practical examples for setting up EF Core, modeling entities, performing data access operations, managing migrations, optimizing performance, testing, and integrating with ASP.NET Core. This resource is ideal for both beginners and experienced developers looking to learn or enhance their skills. Contributions and feedback are welcome to improve the project. Join us in exploring the power of EF Core!
  
<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Projects Structure
- EFCore5WebApp
- EFCore5WebApp.Core
- EFCore5WebApp.Core.Tests
- EFCore5WebApp.DAL
- EFCore5WebApp.DAL.Tests

### Built With

* [![.NET][DOTNET]][DOTNET-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

Before you begin, ensure that you have the following prerequisites installed on your system:
* [Git](https://git-scm.com/)
* [NET Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)



### Installation

1. Clone the project using the following command:
```sh
git clone <project_url>
```
2. Create an appsettings.json file in the EFCore5WebApp project and add your sql server connection.
```json
{
   "ConnectionStrings": {       
      "connection": "Server=YOURSERVERNAME; Database=YOURDATABASENAME; Trusted_Connection=True; MultipleActiveResultSets=true"        
    } 
}
```

3. Apply a migration to the database by running the following command in the terminal within the EFCore5WebApp.DAL project:
   ```sh
   dotnet database update
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage

1. Navigate to the EFCore5WebApp project.
2. Restore the project dependencies by running the following command:
```sh
dotnet restore
```
3. Start the project by running the following command:
```sh
dotnet run
```

_These steps will help you get started with the project. Clone the repository, configure the necessary settings, apply the database migration, and run the project. Feel free to reach out if you have any questions or issues. Happy coding!_

_For more examples, please refer to the [Documentation](https://github.com/teabinxiong/efcore-sample)_

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Update framework and library to utilize .NET 6
- [ ] Pending...


See the [open issues](https://github.com/teabinxiong/efcore-sample/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the Apache License Version 2.0. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

TEA BINXIONG - teabinxiong@gmail.com

Project Link: [https://github.com/teabinxiong/efcore-sample](https://github.com/teabinxiong/efcore-sample)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/teabinxiong/efcore-sample.svg?style=for-the-badge
[contributors-url]: https://github.com/teabinxiong/efcore-sample/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/teabinxiong/efcore-sample.svg?style=for-the-badge
[forks-url]: https://github.com/teabinxiong/efcore-sample/network/members
[stars-shield]: https://img.shields.io/github/stars/teabinxiong/efcore-sample.svg?style=for-the-badge
[stars-url]: https://github.com/teabinxiong/efcore-sample/stargazers
[issues-shield]: https://img.shields.io/github/issues/teabinxiong/efcore-sample.svg?style=for-the-badge
[issues-url]: https://github.com/teabinxiong/efcore-sample/issues
[license-shield]: https://img.shields.io/github/license/teabinxiong/efcore-sample.svg?style=for-the-badge
[license-url]: https://github.com/teabinxiong/efcore-sample/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/binxiong-tea-72095016b
[product-screenshot]: efcore_showcasing.PNG
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
[DOTNET]: https://img.shields.io/badge/-.NET-blueviolet?style=for-the-badge&logo=dotnet&logoColor=white
[DOTNET-url]: dotnet.microsoft.com/en-us/ 
