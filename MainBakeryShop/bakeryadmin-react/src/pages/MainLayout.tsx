import React from 'react'
import { Outlet } from 'react-router-dom'

import { UploadOutlined, UserOutlined, VideoCameraOutlined, DownOutlined, LogoutOutlined } from '@ant-design/icons';
import { Col, Layout, Menu, Row, Space, Switch, theme, Image, Dropdown, Button, MenuProps } from 'antd';
import "./../assets/images/Logo.png";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

const { Header, Content, Footer, Sider } = Layout;

type Props = {
  setThemeLayout(isDark: boolean): void
}

const MainLayout = ({ setThemeLayout }: Props) => {
  const
    {
      token: { colorBgContainer },
    } = theme.useToken();

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
    }
  ];

  const handleMenuClick: MenuProps['onClick'] = (e) => {
    console.log('click', e);
  };

  const menuProps = {
    items,
    onClick: handleMenuClick,
  };


  return (
    <>
      <Layout style={{ height: "100vh" }}>
        <Header style={{ backgroundColor: "white" }}>
          <Row>
            <Col span={12} >
              <Row>
                <Space style={{ lineHeight: "1.25" }}>
                  <Space direction="horizontal" align='center' >
                    <h2>پنل ادمین فروشگاه نان</h2>
                  </Space>
                  <Space direction="horizontal" align='center' >
                    <Image preview={false} src='Logo.png' alt='logo' width={30} height={30} />
                  </Space>
                </Space>
              </Row>
            </Col>
            <Col span={12}>
              <Row style={{ float: "left" }} >
                <Space direction="horizontal">
                  <Space direction="horizontal" align='center' style={{paddingLeft:'10px'}} >
                    <Switch
                      checkedChildren={<FontAwesomeIcon icon={"sun"} style={{ color: "yellow" }} />}
                      unCheckedChildren={<FontAwesomeIcon icon={"moon"} style={{ color: "darkblue" }} />}
                      defaultChecked
                    />
                  </Space>
                </Space>
                <Space direction="horizontal" align='center' >
                  <Dropdown menu={menuProps} >
                    <Button>
                      <Space>
                        ادمین
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
            color='white'
          >
            <Menu
              // theme='light'
              mode="inline"
              defaultSelectedKeys={['4']}
              items={[UserOutlined, VideoCameraOutlined, UploadOutlined, UserOutlined].map(
                (icon, index) => ({
                  key: String(index + 1),
                  icon: React.createElement(icon),
                  label: `nav ${index + 1}`,
                }),
              )}
            />
          </Sider>
          <Layout>
            <Content style={{ margin: '24px 16px 0' }}>
              <div style={{ padding: 24, minHeight: 360, background: colorBgContainer }}>
                <Outlet />
              </div>
            </Content>
            <Footer style={{ textAlign: 'center' }}>ABA Design ©2023 Created by ABA's BOSS</Footer>
          </Layout>
        </Layout>
      </Layout>

    </>
  )
}

export default MainLayout