import React, { ReactNode } from "react";
import "bootstrap/dist/css/bootstrap-grid.min.css";

interface Props {
  size?: number;
}

export default function Column({
  children,
  size,
}: {
  children: ReactNode;
  size?: number;
}): JSX.Element {
  const strSize = size != null ? "col-" + size : "col";
  return <div className={strSize}>{children}</div>;
}
