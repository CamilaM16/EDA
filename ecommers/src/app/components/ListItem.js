export default function ListItem({ url, title, children }) {
  return (
    <li>
      <a
        href={url}
        className="flex items-center p-2 text-gray-900 rounded-lg dark:text-white hover:bg-gray-100 dark:hover:bg-gray-700 group"
      >
        {children}
        <span className="ms-3">{title}</span>
      </a>
    </li>
  );
}
