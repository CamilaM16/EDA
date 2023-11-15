import DashboardIcon from "@/utils/icons/Dashboard";
import ListItem from "./ListItem";
import ProductsIcon from "@/utils/icons/Products";

export default function UserMenu() {
  return (
    <>
      <h5
        id="drawer-navigation-label"
        className="text-base font-semibold text-gray-500 uppercase dark:text-gray-400"
      >
        Menu
      </h5>
      <ul className="space-y-2 font-medium">
        <ListItem url={"#"} title={"Dashboard"}>
          <DashboardIcon />
        </ListItem>
        <ListItem url={"#"} title={"My Products"}>
          <ProductsIcon />
        </ListItem>
      </ul>
    </>
  );
}
