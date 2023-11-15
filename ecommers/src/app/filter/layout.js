export default function ProductGrid({ children }) {
  return <div className="grid sm:grid-cols-1 md:grid-cols-2 xl:grid-cols-4 lg:grid-cols-3 gap-4">{children}</div>;
}
