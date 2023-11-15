import { Inter } from "next/font/google";
import "./globals.css";
import MenuBar from "./components/Menu";

const inter = Inter({ subsets: ["latin"] });

export const metadata = {
  title: "Snake Ecommers",
  description: "Author Camila Malaga",
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body className={inter.className}>
        <div>
          <aside
            id="separator-sidebar"
            className="fixed top-0 left-0 z-40 w-64 h-screen transition-transform -translate-x-full sm:translate-x-0"
            aria-label="Sidebar"
          >
            <a
              href="https://flowbite.com/"
              className="flex items-center ps-2.5 mb-5 mt-5"
            >
              <img
                src="https://flowbite.com/docs/images/logo.svg"
                className="h-6 me-3 sm:h-7"
                alt="Logo"
              />
              <span className="self-center text-xl font-semibold whitespace-nowrap dark:text-white">
                Snake Ecommers
              </span>
            </a>
            <div className="h-full px-3 py-4 overflow-y-auto bg-gray-50 dark:bg-gray-800">
              <MenuBar/>
            </div>
          </aside>

          <div className="p-4 sm:ml-64">
            {children}
          </div>
        </div>
      </body>
    </html>
  );
}
