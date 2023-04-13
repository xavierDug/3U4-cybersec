import React, { ReactNode } from "react";
import "bootstrap/dist/css/bootstrap-grid.min.css";

export default function Column({
  children,
}: {
  children: ReactNode;
}): JSX.Element {
  return (
    <div className="col">
      {children}
    </div>
  );
}
