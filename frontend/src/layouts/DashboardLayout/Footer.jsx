import { Footer } from "antd/es/layout/layout";

const FooterLayout = () => {
  return (
    <Footer
      className="text-center font-bad-script"
    >
      Copyright © {new Date().getFullYear()} Phát triển bởi <span className="font-bold">Nhóm Low Cortisol</span>
    </Footer>
  );
};

export default FooterLayout;
