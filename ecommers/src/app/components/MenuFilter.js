import DashboardIcon from "@/utils/icons/Dashboard";
import ListItem from "./ListItem";
import ProductsIcon from "@/utils/icons/Products";
import SignInIcon from "@/utils/icons/SignIn";

export default function FilterMenu() {
  return (
    <>
      <h5
        id="drawer-navigation-label"
        className="text-base font-semibold text-gray-500 uppercase dark:text-gray-400"
      >
        Filters
      </h5>
      <ul className="space-y-2 font-medium">
        <ListItem url={"/filter/all"} title={"All Products"}>
          <ProductsIcon />
        </ListItem>
        <ListItem url={"/filter/fashion"} title={"Dashboard"}>
          <DashboardIcon />
        </ListItem>
      </ul>
      <ul className="pt-4 mt-4 space-y-2 font-medium border-t border-gray-200 dark:border-gray-700">
        <ListItem url={"#"} title={"Cart"}>
          <ProductsIcon />
        </ListItem>
        <ListItem url={"#"} title={"Sign In"}>
          <SignInIcon />
        </ListItem>
      </ul>
    </>
  );
}
