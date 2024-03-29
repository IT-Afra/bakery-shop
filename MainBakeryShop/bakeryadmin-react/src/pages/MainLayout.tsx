import React from 'react';
import { Outlet } from 'react-router-dom';
import { BrightnessHighFill, MoonFill } from 'react-bootstrap-icons';
import {
  UserOutlined,
  DownOutlined,
  LogoutOutlined,
  HomeOutlined,
  PlusOutlined,
} from '@ant-design/icons';
import {
  Col,
  Layout,
  Menu,
  Row,
  Space,
  Switch,
  theme,
  Image,
  Dropdown,
  Button,
  MenuProps,
} from 'antd';
import 'assets/images/Logo.png';
import { useNavigate } from 'react-router-dom';
import { AuthContext } from 'contexts/AuthContext';

const { Header, Content, Footer, Sider } = Layout;

type Props = {
  setThemeLayout(isDark: boolean): void;
  isDarkMode: boolean;
};

const MainLayout = ({ setThemeLayout, isDarkMode }: Props) => {
  const {
    token: { colorBgContainer },
  } = theme.useToken();

  const authContext = React.useContext(AuthContext);
  const navigate = useNavigate();

  const items: MenuProps['items'] = [
    {
      label: 'پروفایل',
      key: '1',
      icon: <UserOutlined />,
    },
    {
      label: 'خروج از حساب کاربری',
      key: '2',
      icon: <LogoutOutlined />,
    },
  ];

  const sidebar: MenuProps['items'] = [
    {
      label: 'خانه',
      key: '1',
      icon: <HomeOutlined />,
    },
    {
      label: 'انواع نان',
      key: '2',
      icon: <PlusOutlined />,
    },
  ];

  const handleMenuClick: MenuProps['onClick'] = (e) => {
    if (e.key === '2') {

      authContext.logout();
    }
  };

  const handleSidebarClick: MenuProps['onClick'] = (e) => {
    if (e.key === '1') {
      console.log(e);
      navigate("/home", { replace: true });
    }
    if (e.key === '2') {
      navigate("/typebread", { replace: true });
    }
  };

  const menuProps = {
    items,
    onClick: handleMenuClick,
  };

  const changeMode = () => {
    if (isDarkMode) {
      setThemeLayout(false);
    } else {
      setThemeLayout(true);
    }
  };
  return (
    <>
      <Layout style={{ height: '100vh' }}>
        <Header style={{ backgroundColor: isDarkMode ? 'rgb(20, 20, 20)' : 'white' }}>
          <Row>
            <Col span={12}>
              <Row>
                <Space style={{ lineHeight: '1.25' }}>
                  <Space direction="horizontal" align="center">
                    <h2>پنل ادمین فروشگاه نان</h2>
                  </Space>
                  <Space direction="horizontal" align="center">
                    <Image preview={false} src="Logo.png" alt="logo" width={30} height={30} />
                  </Space>
                </Space>
              </Row>
            </Col>
            <Col span={12}>
              <Row style={{ float: 'left' }}>
                <Space direction="horizontal">
                  <Space direction="horizontal" align="center" style={{ paddingLeft: '10px' }}>
                    <Switch
                      onClick={() => changeMode()}
                      checkedChildren={
                        <BrightnessHighFill
                          color="yellow"
                          size={17}
                          style={{ verticalAlign: 'middle', display: 'inline' }}
                        />
                      }
                      unCheckedChildren={
                        <MoonFill
                          color="yellow"
                          size={17}
                          style={{ verticalAlign: 'middle', display: 'inline' }}
                        />
                      }
                      defaultChecked
                    />
                  </Space>
                </Space>
                <Space direction="horizontal" align="center">
                  <Dropdown menu={menuProps}>
                    <Button>
                      <Space>
                        {authContext.userToken ? authContext.userToken.name : 'aaaaa'}
                        <DownOutlined />
                      </Space>
                    </Button>
                  </Dropdown>
                </Space>
              </Row>
            </Col>
          </Row>
          <Menu
            // theme='light'
            mode="horizontal"
          />
        </Header>
        <Layout>
          <Sider
            breakpoint="lg"
            collapsedWidth="0"
            style={{ backgroundColor: isDarkMode ? 'rgb(20, 20, 20)' : 'white' }}
          >
            <Menu
              // theme='light'
              mode="inline"
              defaultSelectedKeys={['1']}
              items={sidebar}
              onClick={handleSidebarClick}
            />
          </Sider>
          <Layout>
            <Content style={{ margin: '24px 16px 0' }}>
              <div style={{ padding: 24, minHeight: 360, background: colorBgContainer }}>
                <Outlet />
              </div>
            </Content>
            <Footer style={{ textAlign: 'center' }}>پنل فروشگاه نان نمامی حقوق محفوظ است.</Footer>
          </Layout>
        </Layout>
      </Layout>
    </>
  );
};

export default MainLayout;
