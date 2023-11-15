import StarDarkIcon from "@/utils/icons/StarDark";
import StarIcon from "@/utils/icons/StarLigth";

export default function Stars({ number }) {
  return (
    <div class="flex items-center mt-2.5 mb-5">
      <div class="flex items-center space-x-1 rtl:space-x-reverse">
        <StarIcon/>
        <StarIcon/>
        <StarIcon/>
        <StarIcon/>
        <StarDarkIcon />
      </div>
      <span class="bg-blue-100 text-blue-800 text-xs font-semibold px-2.5 py-0.5 rounded dark:bg-blue-200 dark:text-blue-800 ms-3">
        {number}
      </span>
    </div>
  );
}
