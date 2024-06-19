# BlogBlaze

A simple demo blog with Blazor.

- Dotnet 8 / Blazor
- Tailwind CSS
- Support markdown for posts
- SQLite for storage

**Todo**:

- Lacks a way to enter posts. Need to add a form to create posts.
- General styling
- SEO features
- Static generation / caching

## Getting Started

Go to `BlogBlaze/BlogBlaze` and install JS dependencies with `pnpm install`.

You can run the project with `pnpm dev` in the same folder. This will -

- Run the dotnet project BlogBlaze in watch mode - `dotnet watch run`
- Run tailwindcss in watch mode - `npx tailwindcss -i ./wwwroot/css/styles.css -o ./wwwroot/css/styles.css --watch`
